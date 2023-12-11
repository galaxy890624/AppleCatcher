using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveManager
{
    #region 單例設計模式
    public static SaveManager instance
    {
        get // 當有人讀取我，當有人需要我、使用我
        {
            // 如果我不存在於記憶體中
            if (_instance == null)
            {
                // 那麼我就自己創造自己
                _instance = new SaveManager();
            }
            // 回傳給對方
            return _instance;
        }
    }
    static SaveManager _instance = null;
    #endregion

    /// <summary> 分數 </summary>
    public int Score
    {
        get
        {
            return _Score;
        }
        set
        {
            _Score = value;
            if (分數變化事件 != null)
            {
                分數變化事件.Invoke();
            }
        }
    }
    int _Score = 0;
    public Action 分數變化事件 = null;

    /// <summary>最高分(存讀檔)</summary>
    public int HighScore
    {
        // 當有人讀取最高分的時候 直接去硬碟查詢HighScore值
        // 如果查不到就給0
        get
        {
            return PlayerPrefs.GetInt("HighScore", 0);
        }
        // 當有人寫入最高分的時候 將這個值存到硬碟的HighScore值當中
        set
        {
            PlayerPrefs.SetInt("HighScore", value);
        }
    }
}