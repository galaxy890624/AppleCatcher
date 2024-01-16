using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCatcher : MonoBehaviour
{
    // Physics
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print($"<color=#ff00ff>�I�쪺����: <color=#00ff00>{collision.gameObject.name}</color></color>");
        if (collision.gameObject.name == "Player" )
        {
            Destroy(gameObject);
        }
    }
}
