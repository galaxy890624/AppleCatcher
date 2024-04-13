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

    /// <summary>
    /// 升級技能
    /// </summary>
    /// <param name="UpgradeSkill">要升級的技能</param>
    public void UpgradeSkill(DataSkill UpgradeSkill)
    {
        print($"<color=#ff00ff>升級技能 : <color=#00ff00>{UpgradeSkill.SkillName}</color></color>");
        if (UpgradeSkill.SkillName == "玩家移動速度") // 必須和ScriptableObject內的SkillName一致
        {
            MoveSpeed.Upgrade();
        }
    }
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

    /// <summary>
        /// 升級技能
        /// </summary>
        /// <param name="UpgradeSkill">要升級的技能</param>
        public void UpgradeSkill(DataSkill UpgradeSkill)
        {
            print($"<color=#ff00ff>升級技能 : <color=#00ff00>{UpgradeSkill.SkillName}</color></color>");
            if (UpgradeSkill.SkillName == "恢復獵人血量" )
            {
                Skill6Hp.Upgrade();
            }
            if (UpgradeSkill.SkillName == "箭間隔")
            {
                Skill1Interval.Upgrade();
            }
            if (UpgradeSkill.SkillName == "箭攻擊力")
            {
                Skill2Attack.Upgrade();
            }
            if (UpgradeSkill.SkillName == "箭數量")
            {
                Skill3Count.Upgrade();
            }
            if (UpgradeSkill.SkillName == "水平速度")
            {
                Skill4PlayerHorizontalSpeed.Upgrade();
            }
            if (UpgradeSkill.SkillName == "箭發射速度")
            {
                Skill5Speed.Upgrade();
            }
            if (UpgradeSkill.SkillName == "箭大小")
            {
                Skill7Size.Upgrade();
            }
        }
*/