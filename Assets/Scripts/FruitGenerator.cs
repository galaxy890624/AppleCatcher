using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("���G����")] // ������ Lv 0 �ƨ� Lv 7
    public GameObject[] FruitLevel = null;
    // Vector3 InitialPosition;
    [Header("�����"), Tooltip("�o�O���G�X�{�̥��䪺��m����")]
    public float LimitLeft = -9.5f;
    [Header("�k���"), Tooltip("�o�O���G�X�{�̥k�䪺��m����")]
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
            random = UnityEngine.Random.Range(0, 3); // �H���ͦ� Lv0 ~ Lv3 �����G
            Generator.position = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
            Instantiate(FruitLevel[random], Generator.position, Quaternion.identity);
            SpawnTime += 1f; // Delay 1��
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
    public GameObject[] fruitPrefabs; // �s����GPrefab���}�C
    public float spawnInterval = 2f;  // �ͦ����G���ɶ����j
    public float spawnRangeX = 9.5f;    // �ͦ����G��X�b�d��

    void Start()
    {
        // �Ұʨ�{�A�Ω�w���ͦ����G
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits()
    {
        while (true)
        {
            // �H����ܤ@�Ӥ��GPrefab
            GameObject randomFruit = fruitPrefabs[Random.Range(0, fruitPrefabs.Length)];

            // �H���ͦ�X�b��m
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);

            // �ͦ����G
            Instantiate(randomFruit, new Vector3(spawnPosX, transform.position.y, 0), Quaternion.identity);

            // ���ݫ��w���ɶ����j�A�ͦ��U�@�Ӥ��G
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // �p�G�I�쪱�a�Φa���A�h�R�����G
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