using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Mathematics;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    Vector3 InitialPosition;
    [Header("�����t��"), Range(0, 10)]
    public float DropSpeed = 2.0f;
    [Header("�����"), Tooltip("�o�O���u�X�{�̥��䪺��m����")]
    public float LimitLeft = -9.5f;
    [Header("�k���"), Tooltip("�o�O���u�X�{�̥k�䪺��m����")]
    public float LimitRight = 9.5f;

    // Initialization
    private void Awake()
    {
        Initialize();
    }
    private void Initialize()
    {
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
    }
    // Physics
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        // �p�G���a�I���
        if (other.tag == "Player")
        {
            SaveManager.instance.Score = 0;
            /*
             * AudioManager.instance.Play("�Y�쬵�u");
             */
            Destroy(this.gameObject); // �R���ۤv���C������
            Next();
        }
    }
    // Game logic
    private void Update()
    {
        Drop();
    }
    private void Drop()
    {
        Vector3 BombPosition = transform.position;
        transform.position = BombPosition;
        // print($"<color=#ff00ff>BombPosition = <color=#00ff00>{BombPosition}</color></color>");
        if(BombPosition.y <= -7.5)
        {
            Destroy(this.gameObject);
            Next();
        }
    }
    private void Next()
    {
        Initialize();
    }
}