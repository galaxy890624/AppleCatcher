using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPMonitor : MonoBehaviour
{
    [SerializeField, Header("��q�R�߹w�m��")]
    GameObject Heart;
    [Header("��q��ܾ�����m")]
    public Transform Parent;
    [SerializeField] List<GameObject> ��qUI = new List<GameObject>(); // ��q���R�ߪ���

    int hp = 5;

    /*private void Awake()
    {
        for (int i = 0; i < SaveManager.instance.��q; i++)
        {
            Instantiate(��qUI[i], new Vector3(-14f + i, 7f, 0f), Quaternion.identity, Parent); // ���HStage���y��
            print($"<color=#ff00ff>�w�ͦ���<color=#00ff00>{i}</color>�ӷR��</color>");
        }
    }*/
    private void Start()
    {
        //SaveManager.instance.�R���ܤƨƥ� += ��s���;
        ��s���();
    }
    private void OnDisable()
    {
        //SaveManager.instance.�R���ܤƨƥ� -= ��s���;
    }

    public void ��s���()
    {
        for (int i = 0; i < hp; i++)
        {
            GameObject HeartList = Instantiate(Heart, new Vector3(-14f + i, 7f, 0f), Quaternion.identity, Parent); // ���HStage���y��
            ��qUI.Add(HeartList);
            print($"<color=#ff00ff>�w�ͦ���<color=#00ff00>{i}</color>�ӷR��</color>");
        }
        //SaveManager.instance.�R���ܤƨƥ� -= ��s���;
    }
    public void Damage()
    {
        Destroy(��qUI[--hp]);
        /*
         * [--hp] ��1������O 4 (�|����)
         * [hp--] ��1������O 5
         */
    }
}
