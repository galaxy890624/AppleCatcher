using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ɯŧޯ�
/// </summary>
public class UpgradeSkill : MonoBehaviour
{
    // protected �O�@ : ���\�����O�P�l���O�s��
    // [SerializeField, Header("�ޯ���")]
    [Header("�ޯ���")]
    public DataSkill Dataskill;

    /// <summary>
    /// �ɯ�
    /// </summary>
    /// virtual ���� : ���\�l���O�ϥ� override �мg
    public virtual void Upgrade()
    {

    }
}