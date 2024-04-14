using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCatcher : MonoBehaviour
{
    public GameObject[] Bomb = null;
    public Item Item; // �n����ҤƤ~���
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
            //print($"<color=#ff00ff>�ڱ���<color=#00ff00>{gameObject.name}</color>�F��!</color>");
            //print($"{UnityEditor.ArrayUtility.IndexOf<GameObject>(Bomb, gameObject)}"); // Input = ..\Prefabs\Cherries ; Output = 2
            // �Y�쬵�u �ƶq�N + 1
            Item.ItemQuantity += 1;

            SaveManager.instance.Score -= (UnityEditor.ArrayUtility.IndexOf<GameObject>(Bomb, gameObject) + 1); // ����
            SaveManager.instance.��q -= 1;

            Destroy(gameObject);
            for (int i = 0; i < transform.childCount; i++)
            {
                print($"<color=#ff00ff>�w�R����<color=#00ff00>{i}</color>�ӷR�� : <color=#00ff00>{transform.GetChild(0).name}</color></color>");
                Destroy(transform.GetChild(0).gameObject); // ��for�j��, �C�����R����1��(index = 0)�l����
            }
        }
        else if (collision.tag == "Ground")
        {
            //print($"<color=#ff00ff><color=#00ff00>{gameObject.name}</color>���b�a�W�F��!</color>");
            Destroy(gameObject);
        }
    }
}
