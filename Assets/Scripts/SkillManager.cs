using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    #region singleton
    public static SkillManager Instance;

    /// <summary>
    /// �H���ޯ���
    /// </summary>
    public DataSkill RandomSkill => DataSkills[Random.Range(0, DataSkills.Length)];
    [SerializeField, Header("�����ޯ���")]
    private DataSkill[] DataSkills = null;

    [SerializeField, Header("���a���ʳt��")]
    private UpgradeSkill MoveSpeed;

    private void Awake()
    {
        Instance = this;
    }
    #endregion
}

/*
 * [SerializeField, Header("�����ޯ���")]
    private DataSkill[] DataSkills = null;
    [SerializeField, Header("�ޯ�_6_�ɦ�")]
    private UpgradeSkill Skill6Hp;
    [SerializeField, Header("�ޯ�_1_���j")]
    private UpgradeSkill Skill1Interval;
    [SerializeField, Header("�ޯ�_2_�����O")]
    private UpgradeSkill Skill2Attack;
    [SerializeField, Header("�ޯ�_3_�ƶq")]
    private UpgradeSkill Skill3Count;
    [SerializeField, Header("�ޯ�_4_���a�����t��")]
    private UpgradeSkill Skill4PlayerHorizontalSpeed;
    [SerializeField, Header("�ޯ�_5_����t��")]
    private UpgradeSkill Skill5Speed;
    [SerializeField, Header("�ޯ�_7_�ؤo")]
    private UpgradeSkill Skill7Size;
*/