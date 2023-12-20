using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
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
    int random = 0; // global
    float Delay = 0f;
    int GetScorePow(int x, int y) // �p��pow(int x, int y) && y >= 0
    {
        if (y == 0)
        {
            return 1;
        }
        return x * GetScorePow(x, y - 1);
    }
    #region ��ҳ]�p�Ҧ�
    public static FruitGenerator instance
    {
        get // ���HŪ����
        {
            // �p�G�ڤ��s�b��O���餤
            if (_instance == null)
            {
                // ����ڴN�ۤv�гy�ۤv
                _instance = new FruitGenerator();
            }
            // �^�ǵ����
            return _instance;
        }
    }
    static FruitGenerator _instance = null;
    #endregion
    // Initialization
    private void OnEnable() // �}�l�ϥΩҦ�gameObject
    {
        Initialize();
    }
    private void Initialize()
    {
        random = UnityEngine.Random.Range(0, 3); // �H���ͦ� Lv0 ~ Lv3 �����G
        for (int i = 0; i < FruitLevel.Length; i++) // �}�l�ɱN�Ҧ���������
        {
            FruitLevel[i].SetActive(false);
            print("<color=#0f7fff>�ڦ�<color=#ff00ff>��������</color>��</color>");
        }
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        FruitLevel[random].SetActive(true); // ��n�ͦ������G���󥴶}
        print("<color=#0f7fff>�ڦ�<color=#ff00ff>���}����</color>��</color>");
    }
    // Physics
    private void OnTriggerEnter2D(UnityEngine.Collider2D other) // ��ҳ]�pSS
    {
        // �p�G���a�I���
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += GetScorePow(2, random);
            /*
             * AudioManager.instance.Play("�Y����G");
             */
            this.gameObject.SetActive(false); // �R���ۤv���C������
            print("<color=#0f7fff>�ڦ��q<color=#ff00ff>Collider2D</color>�i��<color=#ff0000>OnDisable()</color>��</color>");
        }
        else if (other.tag == "Ground")
        {
            this.gameObject.SetActive(false);
            print("<color=#0f7fff>�ڦ��q<color=#ff00ff>Collider2D</color>�i��<color=#ff0000>OnDisable()</color>��</color>");
        }
        // FruitGenerator.instance.Initialize();
    }
    // Game logic
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        FruitLevel[random].SetActive(true); // ��n�ͦ������G���󥴶}
        Vector3 FruitPosition = transform.position;
        transform.position = FruitPosition;
    }
    // Decommissioning
    private void OnDisable() // �|����ϥΩҦ�gameObject
    {
        Initialize();
        print("<color=#0f7fff>�ڦ��q<color=#ff00ff>OnDisable()</color>�i��<color=#ff0000>Initialize()</color>��</color>");
    }
}
//�ƥε{��
//Invoke("Initialize", 2); // ����2���, �i�JInitialize
//Instantiate(this.gameObject); // �ͦ��ۤv���C������
//InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
//transform.position = InitialPosition;
//Instantiate(FruitLevel[random], new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f), Quaternion.identity);