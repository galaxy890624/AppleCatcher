using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���a���ޯ���
/// </summary>
[CreateAssetMenu(menuName = "Skills/New Skill")]

public class DataSkill : ScriptableObject
{
    [Header("�ޯ�W��")]
    public string SkillName;
    [Header("�ޯ൥��"), Range(0, 20)]
    public int Lv = 0;
    [Header("�ޯ�C�ӵ��ů�O��")]
    public float[] SkillValues = null;

    // Lambda �B��l (²�g)
    // Lambda �Ÿ���i�H�B��μg�{��

    /// <summary>
    /// �ثe�ޯ઺��O��
    /// </summary>
    public float SkillValue => SkillValues[Lv - 1];
}
