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

    /// <summary>
    /// �ɯŧޯ�
    /// </summary>
    /// <param name="UpgradeSkill">�n�ɯŪ��ޯ�</param>
    public void UpgradeSkill(DataSkill UpgradeSkill)
    {
        print($"<color=#ff00ff>�ɯŧޯ� : <color=#00ff00>{UpgradeSkill.SkillName}</color></color>");
        if (UpgradeSkill.SkillName == "�b���j")
        {
            MoveSpeed.Upgrade();
        }
    }
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

    /// <summary>
        /// �ɯŧޯ�
        /// </summary>
        /// <param name="UpgradeSkill">�n�ɯŪ��ޯ�</param>
        public void UpgradeSkill(DataSkill UpgradeSkill)
        {
            print($"<color=#ff00ff>�ɯŧޯ� : <color=#00ff00>{UpgradeSkill.SkillName}</color></color>");
            if (UpgradeSkill.SkillName == "��_�y�H��q" )
            {
                Skill6Hp.Upgrade();
            }
            if (UpgradeSkill.SkillName == "�b���j")
            {
                Skill1Interval.Upgrade();
            }
            if (UpgradeSkill.SkillName == "�b�����O")
            {
                Skill2Attack.Upgrade();
            }
            if (UpgradeSkill.SkillName == "�b�ƶq")
            {
                Skill3Count.Upgrade();
            }
            if (UpgradeSkill.SkillName == "�����t��")
            {
                Skill4PlayerHorizontalSpeed.Upgrade();
            }
            if (UpgradeSkill.SkillName == "�b�o�g�t��")
            {
                Skill5Speed.Upgrade();
            }
            if (UpgradeSkill.SkillName == "�b�j�p")
            {
                Skill7Size.Upgrade();
            }
        }
*/