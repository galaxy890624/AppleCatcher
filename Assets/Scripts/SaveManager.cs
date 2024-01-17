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

    /// <summary> ����(�C�����}�k�s) </summary>
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

    /// <summary>���G�ƶq</summary>
    public float FruitQuantity
    {
        get // ���HŪ��FruitQuantity
        {
            return PlayerPrefs.GetFloat("FruitQuantity", 0);
        }
        set // ���H�g�JFruitQuantity
        {
            PlayerPrefs.SetFloat("FruitQuantity", value);
            if (FruitQuantity�ܤƨƥ� != null)
            {
                FruitQuantity�ܤƨƥ�.Invoke();
            }
        }
    }
    public Action FruitQuantity�ܤƨƥ� = null;

    /// <summary>ī�G�ƶq</summary>
    public float AppleQuantity
    {
        get // ���HŪ��AppleQuantity
        {
            return PlayerPrefs.GetFloat("AppleQuantity", 0);
        }
        set // ���H�g�JAppleQuantity
        {
            PlayerPrefs.SetFloat("AppleQuantity", value);
            if (AppleQuantity�ܤƨƥ� != null)
            {
                AppleQuantity�ܤƨƥ�.Invoke();
            }
        }
    }
    public Action AppleQuantity�ܤƨƥ� = null;
}