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
    /// <summary>
    /// �_����ܾ�
    /// </summary>
    public int ��q
    {
        get
        {
            return _��q;
        }
        set
        {
            _��q = value;
            if (�R���ܤƨƥ� != null)
            {
                �R���ܤƨƥ�.Invoke();
            }
        }
    }
    int _��q = 5; // ��l�� = 5
    public Action �R���ܤƨƥ� = null;
}