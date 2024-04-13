using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCatcher : MonoBehaviour
{
    public GameObject[] Bomb = null;
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
            //print($"{UnityEditor.ArrayUtility.IndexOf<GameObject>(Bomb, gameObject)}"); // Input = ..\Prefabs\Cherries ; Output = 2
            // 吃到炸彈 數量就 + 1
            Item.ItemQuantity += 1;

            SaveManager.instance.Score -= (UnityEditor.ArrayUtility.IndexOf<GameObject>(Bomb, gameObject) + 1); // 扣分
            SaveManager.instance.血量 -= 1;

            Destroy(gameObject);
        }
        else if (collision.tag == "Ground")
        {
            //print($"<color=#ff00ff><color=#00ff00>{gameObject.name}</color>掉在地上了唷!</color>");
            Destroy(gameObject);
        }
    }
}
