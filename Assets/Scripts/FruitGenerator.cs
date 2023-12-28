using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("���G����")] // ������ Lv 0 �ƨ� Lv 7
    public GameObject[] FruitLevel = null;
    public float DropSpeed = 2.0f;
    [Header("�����"), Tooltip("�o�O���G�X�{�̥��䪺��m����")]
    public float LimitLeft = -9.5f;
    [Header("�k���"), Tooltip("�o�O���G�X�{�̥k�䪺��m����")]
    public float LimitRight = 9.5f;

    public GameObject Generator = null;

    [Header("��ͦ�����m")]
    public Transform GeneratePosition;

    int random = 0; // global

    private GameObject RandomFruit()
    {
        random = Random.Range(0, 3);
        return FruitLevel[random];
    }
    // Initialize
    private void OnEnable() // �}�l�ϥΩҦ�gameObject
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
