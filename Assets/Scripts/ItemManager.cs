using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using static UnityEditor.Progress;

// 背包系統
// 用來控制Item的儲存
// 參考SkillManager.cs

//[CreateAssetMenu(fileName = "ItemManager", menuName = "Item/ItemManager")] // 右鍵 > Chatbox > ChatboxManager

public class ItemManager : MonoBehaviour
{
    #region singleton
    public static ItemManager Instance;

    /// <summary>
    /// 隨機技能資料
    /// </summary>
    /// Scriptable Object
    /// FruitLevel[0] Apple
    /// FruitLevel[1] Bananas

    //[SerializeField, Header("水果等級FruitLevel")] // 全部水果資料
    //private Item[] FruitLevel = null;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

}