using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    [Header("��q��ܾ�����m")]
    public Transform Parent;
    [SerializeField] List<GameObject> ��qUI = new List<GameObject>(); // ��q���R�ߪ���
    
    private void Start()
    {
        SaveManager.instance.�R���ܤƨƥ� += ��s���;
        ��s���();
    }
    private void OnDisable()
    {
        SaveManager.instance.�R���ܤƨƥ� -= ��s���;
    }

    void ��s���()
    {
        for (int i = 0; i < SaveManager.instance.��q; i++)
        {
            Instantiate(��qUI[i], new Vector3(-14f + i, 7f, 0f), Quaternion.identity, Parent); // ���HStage���y��
            print($"<color=#ff00ff>�w�ͦ���<color=#00ff00>{i}</color>�ӷR��</color>");
        }
    }
}
