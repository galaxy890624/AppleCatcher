using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
public class FruitGenerator : MonoBehaviour
{
    [Header("水果等級")] // 必須由 Lv 0 排到 Lv 7
    public GameObject[] FruitLevel = null;
    Vector3 InitialPosition;
    [Header("掉落速度"), Range(0, 10)]
    public float DropSpeed = 2.0f;
    [Header("左邊界"), Tooltip("這是水果出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是水果出現最右邊的位置限制")]
    public float LimitRight = 9.5f;
    int random = 0; // global
    float Delay = 0f;
    int GetScorePow(int x, int y) // 計算pow(int x, int y) && y >= 0
    {
        if (y == 0)
        {
            return 1;
        }
        return x * GetScorePow(x, y - 1);
    }
    #region 單例設計模式
    public static FruitGenerator instance
    {
        get // 當有人讀取我
        {
            // 如果我不存在於記憶體中
            if (_instance == null)
            {
                // 那麼我就自己創造自己
                _instance = new FruitGenerator();
            }
            // 回傳給對方
            return _instance;
        }
    }
    static FruitGenerator _instance = null;
    #endregion
    // Initialization
    private void OnEnable() // 開始使用所有gameObject
    {
        Initialize();
    }
    private void Initialize()
    {
        random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv3 的水果
        for (int i = 0; i < FruitLevel.Length; i++) // 開始時將所有物件關閉
        {
            FruitLevel[i].SetActive(false);
            print("<color=#0f7fff>我有<color=#ff00ff>關閉物件</color>唷</color>");
        }
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        FruitLevel[random].SetActive(true); // 把要生成的水果物件打開
        print("<color=#0f7fff>我有<color=#ff00ff>打開物件</color>唷</color>");
    }
    // Physics
    private void OnTriggerEnter2D(UnityEngine.Collider2D other) // 單例設計SS
    {
        // 如果玩家碰到我
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += GetScorePow(2, random);
            /*
             * AudioManager.instance.Play("吃到水果");
             */
            this.gameObject.SetActive(false); // 刪除自己的遊戲物件
            print("<color=#0f7fff>我有從<color=#ff00ff>Collider2D</color>進到<color=#ff0000>OnDisable()</color>唷</color>");
        }
        else if (other.tag == "Ground")
        {
            this.gameObject.SetActive(false);
            print("<color=#0f7fff>我有從<color=#ff00ff>Collider2D</color>進到<color=#ff0000>OnDisable()</color>唷</color>");
        }
        // FruitGenerator.instance.Initialize();
    }
    // Game logic
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        FruitLevel[random].SetActive(true); // 把要生成的水果物件打開
        Vector3 FruitPosition = transform.position;
        transform.position = FruitPosition;
    }
    // Decommissioning
    private void OnDisable() // 會停止使用所有gameObject
    {
        Initialize();
        print("<color=#0f7fff>我有從<color=#ff00ff>OnDisable()</color>進到<color=#ff0000>Initialize()</color>唷</color>");
    }
}
//備用程式
//Invoke("Initialize", 2); // 等待2秒後, 進入Initialize
//Instantiate(this.gameObject); // 生成自己的遊戲物件
//InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
//transform.position = InitialPosition;
//Instantiate(FruitLevel[random], new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f), Quaternion.identity);