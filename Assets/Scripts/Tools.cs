using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
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
}
