using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("���G����")] // ������ Lv 0 �ƨ� Lv 7
    public GameObject[] FruitLevel = null;
    Vector3 InitialPosition;
    [Header("�����t��"), Range(0, 10)]
    public float DropSpeed = 2.0f;
    [Header("�����"), Tooltip("�o�O���G�X�{�̥��䪺��m����")]
    public float LimitLeft = -9.5f;
    [Header("�k���"), Tooltip("�o�O���G�X�{�̥k�䪺��m����")]
    public float LimitRight = 9.5f;
    int random = 0;

    int GetScorePow(int x, int y) // y >= 0
    {
        if (y == 0)
        {
            return 1;
        }
        return x * GetScorePow(x, y - 1);
    }

    // Initialization
    private void Awake()
    {
        Initialize();
    }
    private void Initialize()
    {
        for (int i = 0; i < FruitLevel.Length; i++) // �}�l�ɱN�Ҧ���������
        {
            FruitLevel[i].SetActive(false);
        }
        random = UnityEngine.Random.Range(0, 3); // �H���ͦ� Lv0 ~ Lv3 �����G
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        FruitLevel[random].SetActive(true); // ��n�ͦ������G���󥴶}
    }
    // Physics
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        // �p�G���a�I���
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += GetScorePow(2, random);
            /*
             * AudioManager.instance.Play("�Y����G");
             */
            Destroy(this.gameObject); // �R���ۤv���C������
            OnDisable();
            print("<color=#0f7fff>�ڦ��q<color=#ff00ff>Collider2D</color>�i��<color=#ff0000>OnDisable()</color>��</color>");
        }
    }
    // Game logic
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        Vector3 FruitPosition = transform.position;
        transform.position = FruitPosition;
        if(FruitPosition.y <= -7.5)
        {
            Destroy(this.gameObject);
            OnDisable();
            print("<color=#0f7fff>�ڦ��q<color=#ff00ff>Drop()</color>�i��<color=#ff0000>OnDisable()</color>��</color>");
        }
    }
    private void OnDisable()
    {
        Initialize();
        Instantiate(this.gameObject); // �ͦ��ۤv���C������
        print("<color=#0f7fff>�ڦ��q<color=#ff00ff>OnDisable()</color>�i��<color=#ff0000>Initialize()</color>��</color>");
    }
}