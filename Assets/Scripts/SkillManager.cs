using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    #region singleton
    public static SkillManager Instance;

    /// <summary>
    /// 隨機技能資料
    /// </summary>
    public DataSkill RandomSkill => DataSkills[Random.Range(0, DataSkills.Length)];
    [SerializeField, Header("全部技能資料")]
    private DataSkill[] DataSkills = null;

    [SerializeField, Header("玩家移動速度")]
    private UpgradeSkill MoveSpeed;

    private void Awake()
    {
        Instance = this;
    }
    #endregion
}

/*
 * [SerializeField, Header("全部技能資料")]
    private DataSkill[] DataSkills = null;
    [SerializeField, Header("技能_6_補血")]
    private UpgradeSkill Skill6Hp;
    [SerializeField, Header("技能_1_間隔")]
    private UpgradeSkill Skill1Interval;
    [SerializeField, Header("技能_2_攻擊力")]
    private UpgradeSkill Skill2Attack;
    [SerializeField, Header("技能_3_數量")]
    private UpgradeSkill Skill3Count;
    [SerializeField, Header("技能_4_玩家水平速度")]
    private UpgradeSkill Skill4PlayerHorizontalSpeed;
    [SerializeField, Header("技能_5_飛行速度")]
    private UpgradeSkill Skill5Speed;
    [SerializeField, Header("技能_7_尺寸")]
    private UpgradeSkill Skill7Size;
*/