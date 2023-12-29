using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("水果等級")] // 必須由 Lv 0 排到 Lv 7
    public GameObject[] FruitLevel = null;
    public float DropSpeed = 2.0f;
    [Header("左邊界"), Tooltip("這是水果出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是水果出現最右邊的位置限制")]
    public float LimitRight = 9.5f;

    public GameObject Generator = null;

    [Header("放生成物位置")]
    public Transform GeneratePosition;

    int random = 0; // global

    private GameObject RandomFruit()
    {
        random = Random.Range(0, 3);
        return FruitLevel[random];
    }
    // Initialize
    private void OnEnable() // 開始使用所有gameObject
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
