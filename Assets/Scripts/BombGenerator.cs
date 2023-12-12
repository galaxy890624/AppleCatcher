using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    Vector3 InitialPosition;
    [Header("掉落速度"), Range(0, 10)]
    public float DropSpeed = 2.0f;
    [Header("左邊界"), Tooltip("這是炸彈出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是炸彈出現最右邊的位置限制")]
    public float LimitRight = 9.5f;

    // Initialization
    private void Awake()
    {
        Initialize();
    }
    private void Initialize()
    {
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
    }
    // Physics
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        // 如果玩家碰到我
        if (other.tag == "Player")
        {
            SaveManager.instance.Score = 0;
            /*
             * AudioManager.instance.Play("吃到炸彈");
             */
            Destroy(this.gameObject); // 刪除自己的遊戲物件
            Next();
        }
    }
    // Game logic
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        Vector3 BombPosition = transform.position;
        transform.position = BombPosition;
        // print($"<color=#ff00ff>BombPosition = <color=#00ff00>{BombPosition}</color></color>");
        if(BombPosition.y <= -7.5)
        {
            Destroy(this.gameObject);
            Next();
        }
    }
    private void Next()
    {
        Initialize();
    }
}