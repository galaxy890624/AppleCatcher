using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class FruitCatcher : MonoBehaviour
{
    public GameObject[] FruitLevel = null;
    // Physics
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print($"<color=#ff00ff>我接到<color=#00ff00>{gameObject.name}</color>了唷!</color>");
            print($"{UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject)}"); // Input = ..\Prefabs\Cherries ; Output = 2
            /*for (int i = 0; i < FruitLevel.Length; i++)
            {
                if (i == UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject))
                {
                    
                }
            }*/
            SaveManager.instance.Score += (UnityEditor.ArrayUtility.IndexOf<GameObject>(FruitLevel, gameObject) + 1);
            Destroy(gameObject);
        }
        else if (collision.tag == "Ground")
        {
            print($"<color=#ff00ff><color=#00ff00>{gameObject.name}</color>掉在地上了唷!</color>");
            Destroy(gameObject);
        }
    }
}