using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCatcher : MonoBehaviour
{
    public GameObject[] Bomb = null;
    public Item Item; // 要先實例化才能用
    public Transform Parent;

    // initialize
    private void Awake()
    {
        
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
            for (int i = 0; i < transform.childCount; i++)
            {
                print($"<color=#ff00ff>已刪除第<color=#00ff00>{i}</color>個愛心 : <color=#00ff00>{transform.GetChild(0).name}</color></color>");
                Destroy(transform.GetChild(0).gameObject); // 用for迴圈, 每次都刪除第1個(index = 0)子物件
            }
        }
        else if (collision.tag == "Ground")
        {
            //print($"<color=#ff00ff><color=#00ff00>{gameObject.name}</color>掉在地上了唷!</color>");
            Destroy(gameObject);
        }
    }
}
