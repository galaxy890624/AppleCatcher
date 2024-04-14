using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    [Header("炸彈")]
    public GameObject[] Bomb = null; // 所有炸彈的Prefabs
    // Vector3 InitialPosition;
    [Header("左邊界"), Tooltip("這是水果出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是水果出現最右邊的位置限制")]
    public float LimitRight = 9.5f;
    [Header("生成炸彈的位置")]
    public Transform Generator;
    int random = 0;
    float SpawnTime = 0f; // 生成炸彈的計時器

    // Game logic
    private void Update()
    {
        if (Time.timeSinceLevelLoad > SpawnTime) // 為了中途進入遊玩場景, 不要從一進遊戲就開始累積炸彈, 所以不能用Time.time
        {
            //random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv2 的水果
            Generator.position = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
            Instantiate(Bomb[random], Generator.position, Quaternion.identity);
            SpawnTime += 5f; // Delay 5秒
        }
    }
}
