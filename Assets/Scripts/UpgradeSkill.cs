using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 升級技能
/// </summary>
public class UpgradeSkill : MonoBehaviour
{
    // protected 保護 : 允許此類別與子類別存取
    // [SerializeField, Header("技能資料")]
    [Header("技能資料")]
    public DataSkill Dataskill;

    /// <summary>
    /// 升級
    /// </summary>
    /// virtual 虛擬 : 允許子類別使用 override 覆寫
    public virtual void Upgrade()
    {

    }
}