using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveManager
{
    #region ��ҳ]�p�Ҧ�
    public static SaveManager instance
    {
        get // ���HŪ���ڡA���H�ݭn�ڡB�ϥΧ�
        {
            // �p�G�ڤ��s�b��O���餤
            if (_instance == null)
            {
                // ����ڴN�ۤv�гy�ۤv
                _instance = new SaveManager();
            }
            // �^�ǵ����
            return _instance;
        }
    }
    static SaveManager _instance = null;
    #endregion

    /// <summary> ���� </summary>
    public int Score
    {
        get
        {
            return _Score;
        }
        set
        {
            _Score = value;
            if (�����ܤƨƥ� != null)
            {
                �����ܤƨƥ�.Invoke();
            }
        }
    }
    int _Score = 0;
    public Action �����ܤƨƥ� = null;

    /// <summary>�̰���(�sŪ��)</summary>
    public int HighScore
    {
        // ���HŪ���̰������ɭ� �����h�w�Ьd��HighScore��
        // �p�G�d����N��0
        get
        {
            return PlayerPrefs.GetInt("HighScore", 0);
        }
        // ���H�g�J�̰������ɭ� �N�o�ӭȦs��w�Ъ�HighScore�ȷ�
        set
        {
            PlayerPrefs.SetInt("HighScore", value);
        }
    }
    /// <summary>ī�G�ƶq</summary>
    public float AppleQuantity
    {
        get // ���HŪ��AppleQuantity
        {
            return _AppleQuantity;
        }
        set // ���H�g�JAppleQuantity
        {
            // ����d��b0~�̤j����
            // _AppleQuantity = Mathf.Clamp(value, 0f, maxAppleQuantity);
            // ��H�ק���O�ɳq���Ҧ��q�\�ڪ��Τ�
            if (AppleQuantity�ܤƨƥ� != null)
            {
                AppleQuantity�ܤƨƥ�.Invoke();
            }
        }
    }
    float _AppleQuantity = 0f; // test
    //public float maxAppleQuantity = 10f;
    public Action AppleQuantity�ܤƨƥ� = null;
}