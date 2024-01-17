using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCatcher : MonoBehaviour
{
    // Physics
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print($"<color=#ff00ff>我接到<color=#00ff00>{gameObject.name}</color>了唷!</color>");
            Destroy(gameObject);
        }
        else if (collision.tag == "Ground" )
        {
            print($"<color=#ff00ff><color=#00ff00>{gameObject.name}</color>掉在地上了唷!</color>");
            Destroy(gameObject);
        }
    }
}
