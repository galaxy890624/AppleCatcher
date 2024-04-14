using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 用來儲存水果的資訊
// ex: 水果動畫, index, 得分, ...
// 參考DataSkill.cs

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")] // 右鍵 > Item > New Item

public class Item : ScriptableObject
{
    public int Index;
    public string ItemName;
    public Sprite ItemImage; // 頭像圖片
    public int GetScore; // 吃到後得到的分數
    public float ItemQuantity; // 持有數量

}