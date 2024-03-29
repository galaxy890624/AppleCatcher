using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

// 背包系統
// 用來控制Item的儲存
// 參考ChatboxManager.cs

[CreateAssetMenu(fileName = "ItemManager", menuName = "Item/ItemManager")] // 右鍵 > Chatbox > ChatboxManager

public class ItemManager : ScriptableObject
{
    #region singleton
    public static ItemManager Instance;

    /// <summary>
    /// 隨機技能資料
    /// </summary>
    public Item RandomFruit => FruitLevel[Random.Range(0, FruitLevel.Length)];

    [SerializeField, Header("水果等級FruitLevel")]
    private Item[] FruitLevel = null;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    

}