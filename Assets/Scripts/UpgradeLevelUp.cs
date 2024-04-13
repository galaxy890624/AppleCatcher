using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeLevelUp : UpgradeSkill
{
    protected virtual void Awake()
    {
        // 遊戲一開始時恢復 0 等
        Dataskill.Lv = 0;
    }
    public override void Upgrade()
    {
        base.Upgrade();
        Dataskill.Lv++;
        print($"<color=#ff00ff>升級後技能的能力值 = <color=#00ff00>{Dataskill.SkillValue}</color></color>");
    }
}
