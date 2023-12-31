using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("水果等級")] // 必須由 Lv 0 排到 Lv 7
    public GameObject[] FruitLevel = null;
    [Header("左邊界"), Tooltip("這是水果出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是水果出現最右邊的位置限制")]
    public float LimitRight = 9.5f;

    // initialize
    private void OnEnable()
    {
        
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    // decommit
    private void OnDisable()
    {
        
    }
}
