using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text ScoreText = null;
    [SerializeField] Text HighScoreText = null;
    void Start()
    {
        SaveManager.instance.分數變化事件 += 刷新;
        刷新();
    }
    private void Update()
    {
        if (SaveManager.instance.HighScore < SaveManager.instance.Score)
        {
            SaveManager.instance.HighScore = SaveManager.instance.Score;
        }
    }
    private void OnDisable()
    {
        SaveManager.instance.分數變化事件 -= 刷新;
    }
    void 刷新()
    {
        // 將分數用000,000,000的方式顯示
        ScoreText.text = "Score = " + SaveManager.instance.Score.ToString("N0");
        HighScoreText.text = "HighScore = " + SaveManager.instance.HighScore.ToString("N0");
    }
}