using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Unity.Mathematics;
public class Tools : MonoBehaviour
{
    [MenuItem("工具/清除所有資料")]
    static public void 清除資料()
    {
        // 移除所有關於這個遊戲的資料
        PlayerPrefs.DeleteAll();
        // 要求Unity立刻做事 避免在遊戲未執行時不做事
        PlayerPrefs.Save();
    }
    [MenuItem("工具/蘋果+1M")]
    static public void 蘋果增加1M()
    {
        // SaveManager.instance.AppleQuantity += 1000000;
    }
}
