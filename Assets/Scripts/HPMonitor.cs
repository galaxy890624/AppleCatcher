using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    [Header("血量的愛心物件")]
    public GameObject Heart;
    public int HP = 5;
    [Header("血量顯示器的位置")]
    public Transform Parent;
    
    private void Start()
    {
        SaveManager.instance.愛心變化事件 += 刷新顯示;
        刷新顯示();
    }
    private void OnDisable()
    {
        SaveManager.instance.愛心變化事件 -= 刷新顯示;
    }
    [SerializeField] List<GameObject> 血量UI = new List<GameObject>(); // 血量的愛心物件

    void 刷新顯示()
    {
        for (int i = 0; i < HP; i++) // 血量UI.Count
        {
            Instantiate(Heart, Vector3.zero, Quaternion.identity, Parent);
        }
        /*
        for (int i = 0; i < 鑰匙UI.Count; i++)
        {
            // 如果i比道具數量小就顯示
            // 0 < 2 O
            // 1 < 2 O
            // 2 < 2 X
            if (i < SaveManager.instance.任務道具)
            {
                鑰匙UI[i].SetActive(true);
            }
        }*/
    }
}
