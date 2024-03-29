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
    /// <summary>
    /// public List<列表型態> 列表名稱
    /// 列表裡, "List<>"內的資料型態 必須和 "想要指定的.cs檔案" 一致
    /// ex:
    /// public List<Item> itemList = new List<Item>();
    /// </summary>
    public List<Item> itemList = new List<Item>();
}