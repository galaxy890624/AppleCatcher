﻿
using UnityEngine;
public class FruitCatcher : MonoBehaviour
{
    public GameObject[] FruitLevel = null;
    public Item Item; // 要先實例化才能用

    // initialize
    private void OnEnable()
    {
        // 確保 Item 已經被實例化
        if (Item == null)
        {
            // 實例化 Item
            // Item = ScriptableObject.CreateInstance<Item>();
        }
    }

    // Physics
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //print($"<color=#ff00ff>我接到<color=#00ff00>{gameObject.name}</color>了唷!</color>");
            //print($"{UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject)}"); // Input = ..\Prefabs\Cherries ; Output = 2
            // 吃到水果 數量就 + 1
            Item.ItemQuantity += 1;

            SaveManager.instance.Score += (UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject) + 1);
            Destroy(gameObject);
        }
        else if (collision.tag == "Ground")
        {
            //print($"<color=#ff00ff><color=#00ff00>{gameObject.name}</color>掉在地上了唷!</color>");
            Destroy(gameObject);
        }
    }
}