using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    [Header("血量顯示器的位置")]
    public Transform Parent;
    [SerializeField] List<GameObject> 血量UI = new List<GameObject>(); // 血量的愛心物件

    private void Start()
    {
        SaveManager.instance.愛心變化事件 += 刷新顯示;
        刷新顯示();
    }
    private void OnDisable()
    {
        SaveManager.instance.愛心變化事件 -= 刷新顯示;
    }

    void 刷新顯示()
    {
        for (int i = 0; i < SaveManager.instance.血量; i++)
        {
            Instantiate(血量UI[i], new Vector3(-14f + i, 7f, 0f), Quaternion.identity, Parent); // 跟隨Stage的座標
            print($"<color=#ff00ff>已生成第<color=#00ff00>{i}</color>個愛心</color>");
        }
    }
}
