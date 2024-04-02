using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

// 璉╰参
// ノㄓ北Item纗
// 把σSkillManager.cs

[CreateAssetMenu(fileName = "ItemManager", menuName = "Item/ItemManager")] // 龄 > Chatbox > ChatboxManager

public class ItemManager : ScriptableObject
{
    #region singleton
    public static ItemManager Instance;

    /// <summary>
    /// 繦诀м戈
    /// </summary>
    public Item RandomFruit => FruitLevel[Random.Range(0, FruitLevel.Length)];

    [SerializeField, Header("狦单FruitLevel")] // 场狦戈
    private Item[] FruitLevel = null;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

}