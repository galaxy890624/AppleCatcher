using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class FruitCatcher : MonoBehaviour
{
    public GameObject[] FruitLevel = null;
    public Item Item;

    // Physics
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print($"<color=#ff00ff>�ڱ���<color=#00ff00>{gameObject.name}</color>�F��!</color>");
            print($"{UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject)}"); // Input = ..\Prefabs\Cherries ; Output = 2

            /*for (int i = 0; i < FruitLevel.Length; i++)
            {
                if (i == UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject))
                {
                    
                }
            }*/

            // Item.ItemQuantity

            SaveManager.instance.Score += (UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject) + 1);
            Destroy(gameObject);
        }
        else if (collision.tag == "Ground")
        {
            print($"<color=#ff00ff><color=#00ff00>{gameObject.name}</color>���b�a�W�F��!</color>");
            Destroy(gameObject);
        }
    }
}