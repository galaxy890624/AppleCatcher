using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    [Header("��q���R�ߪ���")]
    public GameObject Heart;
    public int HP = 5;
    [Header("��q��ܾ�����m")]
    public Transform Parent;
    
    private void Start()
    {
        SaveManager.instance.�R���ܤƨƥ� += ��s���;
        ��s���();
    }
    private void OnDisable()
    {
        SaveManager.instance.�R���ܤƨƥ� -= ��s���;
    }
    [SerializeField] List<GameObject> ��qUI = new List<GameObject>(); // ��q���R�ߪ���

    void ��s���()
    {
        for (int i = 0; i < HP; i++) // ��qUI.Count
        {
            Instantiate(Heart, new Vector3(0f, 0f, 0f), Quaternion.identity, Parent); // new Vector3(-270f, -245f, 0f)
        }
        /*
        for (int i = 0; i < �_��UI.Count; i++)
        {
            // �p�Gi��D��ƶq�p�N���
            // 0 < 2 O
            // 1 < 2 O
            // 2 < 2 X
            if (i < SaveManager.instance.���ȹD��)
            {
                �_��UI[i].SetActive(true);
            }
        }*/
    }
}
