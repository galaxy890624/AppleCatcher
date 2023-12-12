using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
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

    private void Awake()
    {
        int random = UnityEngine.Random.Range(0, 3); // �H���ͦ� Lv0 ~ Lv3 �����G
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        for (int i = 0; i < FruitLevel.Length; i++) // �}�l�ɱN�Ҧ���������
        {
            FruitLevel[i].SetActive(false);
        }
        FruitLevel[random].SetActive(true); // ��n�ͦ������G���󥴶}
    }
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        Vector3 FruitPosition = transform.position;
        transform.position = FruitPosition;
        print($"<color=#00ff00>FruitPosition = {FruitPosition}</color>");
        if(FruitPosition.y <= -7.5)
        {
            Destroy(this.gameObject);
        }
    }
    // ��z�������I�����Q�I�F
    private void OnTriggerEnter(Collider other)
    {
        // �p�G���a�I���
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += 1;
            print("<color=#00ff00>�I�쪱�a�F</color>");
            /*SaveManager.instance.gem++;
            AudioManager.instance.Play("�_��");
            SaveManager.instance.hp += 1;*/
            Destroy(this.gameObject); // �R���ۤv���C������
        }

    }
}