using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
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
    // Initialization
    private void Awake()
    {
        random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv3 的水果
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        for (int i = 0; i < FruitLevel.Length; i++) // 開始時將所有物件關閉
        {
            FruitLevel[i].SetActive(false);
        }
        FruitLevel[random].SetActive(true); // 把要生成的水果物件打開
    }
    // Physics
    private void OnTriggerEnter(Collider other)
    {
        // 如果玩家碰到我
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += 1;
            print("<color=#ff0000>碰到玩家了</color>");
            /*
             * SaveManager.instance.Score += pow(2, random);
             * AudioManager.instance.Play("吃到水果");
             */
            Destroy(this.gameObject); // 刪除自己的遊戲物件
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
        print($"FruitPosition = <color=#00ff00>{FruitPosition}</color>");
        if(FruitPosition.y <= -7.5)
        {
            Destroy(this.gameObject);
        }
    }
    

    // 穿透類型的碰撞器被碰了
    /*private void OnTriggerEnter(Collider other)
    {
        // 如果玩家碰到我
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += 1;
            print("<color=#00ff00>碰到玩家了</color>");
            // SaveManager.instance.Score += pow(2, random);
            // AudioManager.instance.Play("吃到水果");
            Destroy(this.gameObject); // 刪除自己的遊戲物件
        }

    }*/
}