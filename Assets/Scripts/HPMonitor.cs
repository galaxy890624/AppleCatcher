using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    [Header("��q���R�ߪ���")]
    public GameObject Heart;
    public int HP = 5;
    
    private void Start()
    {
        SaveManager.instance.�R���ܤƨƥ� += ��s���;
        ��s���();
    }
    private void OnDisable()
    {
        SaveManager.instance.�R���ܤƨƥ� -= ��s���;
    }
    [SerializeField] List<GameObject> ��qUI = new List<GameObject>();

    void ��s���()
    {
        for (int i = 0; i < HP; i++)
        {
            ��qUI[i].SetActive(true);
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
