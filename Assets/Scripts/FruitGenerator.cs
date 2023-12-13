using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

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
    int random = 0;

    int GetScorePow(int x, int y) // y >= 0
    {
        if (y == 0)
        {
            return 1;
        }
        return x * GetScorePow(x, y - 1);
    }

    // Initialization
    private void OnEnable()
    {
        Initialize();
    }
    private void Initialize()
    {
        random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv3 的水果
        for (int i = 0; i < FruitLevel.Length; i++) // 開始時將所有物件關閉
        {
            FruitLevel[i].SetActive(false);
        }
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        FruitLevel[random].SetActive(true); // 把要生成的水果物件打開
    }
    // Physics
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        // 如果玩家碰到我
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += GetScorePow(2, random);
            /*
             * AudioManager.instance.Play("吃到水果");
             */
            Destroy(this.gameObject); // 刪除自己的遊戲物件
            OnDisable();
            print("<color=#0f7fff>我有從<color=#ff00ff>Collider2D</color>進到<color=#ff0000>OnDisable()</color>唷</color>");
        }
    }
    // Game logic
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        Vector3 FruitPosition = transform.position;
        transform.position = FruitPosition;
        if(FruitPosition.y <= -7.5)
        {
            Destroy(this.gameObject);
            OnDisable();
            print("<color=#0f7fff>我有從<color=#ff00ff>Drop()</color>進到<color=#ff0000>OnDisable()</color>唷</color>");
        }
    }
    // Decommissioning
    private void OnDisable()
    {
        /*for (int i = 0; i < FruitLevel.Length; i++) // 開始時將所有物件關閉
        {
            FruitLevel[i].SetActive(false);
        }*/
        Initialize();
        Instantiate(this.gameObject); // 生成自己的遊戲物件
        print("<color=#0f7fff>我有從<color=#ff00ff>OnDisable()</color>進到<color=#ff0000>Initialize()</color>唷</color>");
    }
}