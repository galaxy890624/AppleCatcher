using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeLevelUp : UpgradeSkill
{
    protected virtual void Awake()
    {
        // �C���@�}�l�ɫ�_ 0 ��
        Dataskill.Lv = 0;
    }
    public override void Upgrade()
    {
        base.Upgrade();
        Dataskill.Lv++;
        print($"<color=#ff00ff>�ɯū�ޯ઺��O�� = <color=#00ff00>{Dataskill.SkillValue}</color></color>");
    }
}
