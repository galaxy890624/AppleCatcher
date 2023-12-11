using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("���G����")] // ������ Lv 0 �ƨ� Lv 7
    public GameObject[] FruitLevel = null;

    private void Awake()
    {
        int random = UnityEngine.Random.Range(0, FruitLevel.Length);
        print(random);
    }

    // ��z�������I�����Q�I�F
    private void OnTriggerEnter(Collider other)
    {
        // �p�G���a�I���
        if (other.tag == "Player")
        {
            SaveManager.instance.Score += 1;

            /*SaveManager.instance.gem++;
            AudioManager.instance.Play("�_��");
            SaveManager.instance.hp += 1;
            Destroy(this.gameObject); // �R���ۤv���C������*/
        }

    }
}
