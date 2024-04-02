using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using static UnityEditor.Progress;

// �I�]�t��
// �Ψӱ���Item���x�s
// �Ѧ�SkillManager.cs

[CreateAssetMenu(fileName = "ItemManager", menuName = "Item/ItemManager")] // �k�� > Chatbox > ChatboxManager

public class ItemManager : ScriptableObject
{
    #region singleton
    public static ItemManager Instance;

    /// <summary>
    /// �H���ޯ���
    /// </summary>
    public Item RandomFruit => FruitLevel[Random.Range(0, FruitLevel.Length)]; // �H����DataSkill���ޯ�(�ժOwk10)

    [SerializeField, Header("���G����FruitLevel")] // �������G���
    private Item[] FruitLevel = null;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

}