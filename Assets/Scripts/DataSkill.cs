
using UnityEngine;

/// <summary>
/// 玩家的技能資料
/// </summary>
[CreateAssetMenu(menuName = "Skills/New Skill")]

public class DataSkill : ScriptableObject
{
    [Header("技能名稱")]
    public string SkillName;
    [Header("技能等級"), Range(0, 20)]
    public int Lv = 0;
    [Header("技能每個等級能力值")]
    public float[] SkillValues = null;

    // Lambda 運算子 (簡寫)
    // Lambda 符號後可以運算或寫程式

    /// <summary>
    /// 目前技能的能力值
    /// </summary>
    public float SkillValue => SkillValues[Lv - 1];
}
