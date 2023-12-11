using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("水果等級")] // 必須由 Lv 0 排到 Lv 7
    public GameObject[] FruitLevel = null;

    private void Awake()
    {
        int random = UnityEngine.Random.Range(0, FruitLevel.Length);
        print(random);
    }

    // 穿透類型的碰撞器被碰了
    private void OnTriggerEnter(Collider other)
    {
        // 如果玩家碰到我
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += 1;

            /*SaveManager.instance.gem++;
            AudioManager.instance.Play("寶石");
            SaveManager.instance.hp += 1;
            Destroy(this.gameObject); // 刪除自己的遊戲物件*/
        }

    }
}
