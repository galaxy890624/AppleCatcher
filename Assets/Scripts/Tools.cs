using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.Mathematics;
public class Tools : MonoBehaviour
{
    [MenuItem("�u��/�M���Ҧ����")]
    static public void �M�����()
    {
        // �����Ҧ�����o�ӹC�������
        PlayerPrefs.DeleteAll();
        // �n�DUnity�ߨ谵�� �קK�b�C��������ɤ�����
        PlayerPrefs.Save();
    }
    [MenuItem("�u��/�����k�s")]
    static public void �����k�s()
    {
        SaveManager.instance.Score = 0;
    }
    [MenuItem("�u��/ī�G�ƶq�k�s")]
    static public void ī�G�ƶq�k�s()
    {
        SaveManager.instance.AppleQuantity = 0;
    }
    [MenuItem("�u��/ī�G+1M")]
    static public void ī�G�W�[1M()
    {
        SaveManager.instance.AppleQuantity += 1000000;
    }
}
