using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    void Start()
    {
        SaveManager.instance.分數變化事件 += 刷新;
        刷新();
    }
    private void OnDisable()
    {
        SaveManager.instance.分數變化事件 -= 刷新;
    }
    [SerializeField] Text ScoreText = null;
    void 刷新()
    {
        // 將分數用000,000,000的方式顯示
        ScoreText.text = "Score = " + SaveManager.instance.Score.ToString("N0");
    }
}