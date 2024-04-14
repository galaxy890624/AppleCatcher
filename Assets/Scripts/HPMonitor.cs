using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    [SerializeField, Header("血量愛心預置物")]
    GameObject Heart;
    [Header("血量顯示器的位置")]
    public Transform Parent;
    [SerializeField] List<GameObject> 血量UI = new List<GameObject>(); // 血量的愛心物件

    int hp = 5;

    /*private void Awake()
    {
        for (int i = 0; i < SaveManager.instance.血量; i++)
        {
            Instantiate(血量UI[i], new Vector3(-14f + i, 7f, 0f), Quaternion.identity, Parent); // 跟隨Stage的座標
            print($"<color=#ff00ff>已生成第<color=#00ff00>{i}</color>個愛心</color>");
        }
    }*/
    private void Start()
    {
        //SaveManager.instance.愛心變化事件 += 刷新顯示;
        刷新顯示();
    }
    private void OnDisable()
    {
        //SaveManager.instance.愛心變化事件 -= 刷新顯示;
    }

    public void 刷新顯示()
    {
        for (int i = 0; i < hp; i++)
        {
            GameObject HeartList = Instantiate(Heart, new Vector3(-14f + i, 7f, 0f), Quaternion.identity, Parent); // 跟隨Stage的座標
            血量UI.Add(HeartList);
            print($"<color=#ff00ff>已生成第<color=#00ff00>{i}</color>個愛心</color>");
        }
        //SaveManager.instance.愛心變化事件 -= 刷新顯示;
    }
    public void Damage()
    {
        Destroy(血量UI[--hp]);
        /*
         * [--hp] 第1次執行是 4 (會先減)
         * [hp--] 第1次執行是 5
         */
    }
}
