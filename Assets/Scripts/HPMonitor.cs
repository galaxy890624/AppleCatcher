using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    private void Start()
    {
        SaveManager.instance.���ȹD���s += ��s���;
        ��s���();
    }
    private void OnDisable()
    {
        SaveManager.instance.���ȹD���s -= ��s���;
    }
    [SerializeField] List<GameObject> �_��UI = new List<GameObject>();

    void ��s���()
    {
        for (int i = 0; i < �_��UI.Count; i++)
        {
            �_��UI[i].SetActive(false);
        }

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
        }
    }
}
