using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("水果等級")] // 必須由 Lv 0 排到 Lv 7
    public GameObject[] FruitLevel = null;
    Vector3 InitialPosition;
    [Header("左邊界"), Tooltip("這是水果出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是水果出現最右邊的位置限制")]
    public float LimitRight = 9.5f;
    int random = 0;
    // initialize
    private void OnEnable()
    {
        random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv3 的水果
        for (int i = 0; i < FruitLevel.Length; i++) // 開始時將所有物件關閉
        {
            FruitLevel[i].SetActive(false);
            print("<color=#0f7fff>我有<color=#ff00ff>關閉物件</color>唷</color>");
        }
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        FruitLevel[random].SetActive(true); // 把要生成的水果物件打開
        print("<color=#0f7fff>我有<color=#ff00ff>打開物件</color>唷</color>");
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            this.gameObject.SetActive(false); // 刪除自己的遊戲物件
            print("<color=#0f7fff>我有從<color=#ff00ff>Collider2D</color>進到<color=#ff0000>OnDisable()</color>唷</color>");
        }
        else if (other.tag == "Ground")
        {
            this.gameObject.SetActive(false);
            print("<color=#0f7fff>我有從<color=#ff00ff>Collider2D</color>進到<color=#ff0000>OnDisable()</color>唷</color>");
        }
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    // decommit
    private void OnDisable()
    {
        OnEnable();
    }
}
