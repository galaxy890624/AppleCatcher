using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("水果等級")] // 必須由 Lv 0 排到 Lv 7
    public GameObject[] FruitLevel = null;
    // Vector3 InitialPosition;
    [Header("左邊界"), Tooltip("這是水果出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是水果出現最右邊的位置限制")]
    public float LimitRight = 9.5f;
    public Transform Generator;
    int random = 0;
    float SpawnTime = 0f;
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
        if (other.tag == "Player")
        {
            Destroy(Generator);
        }
        else if (other.tag == "Ground")
        {

        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (Time.time > SpawnTime)
        {
            random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv3 的水果
            Generator.position = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
            Instantiate(FruitLevel[random], Generator.position, Quaternion.identity);
            SpawnTime += 1f; // Delay 1秒
        }

    }
    // decommit
    private void OnDisable()
    {
        OnEnable();
    }
}

/*
 * using UnityEngine;
using System.Collections;

public class FruitGenerator : MonoBehaviour
{
    public GameObject[] fruitPrefabs; // 存放水果Prefab的陣列
    public float spawnInterval = 2f;  // 生成水果的時間間隔
    public float spawnRangeX = 9.5f;    // 生成水果的X軸範圍

    void Start()
    {
        // 啟動協程，用於定期生成水果
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits()
    {
        while (true)
        {
            // 隨機選擇一個水果Prefab
            GameObject randomFruit = fruitPrefabs[Random.Range(0, fruitPrefabs.Length)];

            // 隨機生成X軸位置
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);

            // 生成水果
            Instantiate(randomFruit, new Vector3(spawnPosX, transform.position.y, 0), Quaternion.identity);

            // 等待指定的時間間隔再生成下一個水果
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // 如果碰到玩家或地面，則摧毀水果
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Ground"))
        {
            Destroy(other.gameObject);
        }
    }
}
*/