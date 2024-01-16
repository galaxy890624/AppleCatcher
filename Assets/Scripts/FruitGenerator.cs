using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    [Header("�ͦ����G����m")]
    public Transform Generator;
    int random = 0;
    float SpawnTime = 0f;

    // Game logic
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
}