using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    [Header("���u")]
    public GameObject[] Bomb = null; // �Ҧ����u��Prefabs
    // Vector3 InitialPosition;
    [Header("�����"), Tooltip("�o�O���G�X�{�̥��䪺��m����")]
    public float LimitLeft = -9.5f;
    [Header("�k���"), Tooltip("�o�O���G�X�{�̥k�䪺��m����")]
    public float LimitRight = 9.5f;
    [Header("�ͦ����u����m")]
    public Transform Generator;
    int random = 0;
    float SpawnTime = 0f; // �ͦ����u���p�ɾ�

    // Game logic
    private void Update()
    {
        if (Time.timeSinceLevelLoad > SpawnTime) // ���F���~�i�J�C������, ���n�q�@�i�C���N�}�l�ֿn���u, �ҥH�����Time.time
        {
            random = UnityEngine.Random.Range(0, 3); // �H���ͦ� Lv0 ~ Lv2 �����G
            Generator.position = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
            Instantiate(Bomb[random], Generator.position, Quaternion.identity);
            SpawnTime += 1f; // Delay 1��
        }
    }
}
