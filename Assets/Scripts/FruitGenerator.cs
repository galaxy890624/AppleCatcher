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

    private void Awake()
    {
        int random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv3 的水果
        InitialPosition = new Vector3(UnityEngine.Random.RandomRange(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        for (int i = 0; i < FruitLevel.Length; i++) // 開始時將所有物件關閉
        {
            FruitLevel[i].SetActive(false);
        }
        FruitLevel[random].SetActive(true); // 把要生成的水果物件打開
    }
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        Vector3 FruitPosition = transform.position;
        transform.position = FruitPosition;
        if(transform.position.y <= 14.65)
        {
            Destroy(this.gameObject);
        }
    }
    // 穿透類型的碰撞器被碰了
    private void OnTriggerEnter(Collider other)
    {
        // 如果玩家碰到我
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += 1;
            print("<color=#00ff00>碰到玩家了</color>");
            /*SaveManager.instance.gem++;
            AudioManager.instance.Play("寶石");
            SaveManager.instance.hp += 1;*/
            Destroy(this.gameObject); // 刪除自己的遊戲物件
        }

    }
}