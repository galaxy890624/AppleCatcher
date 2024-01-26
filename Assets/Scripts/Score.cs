using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    void Start()
    {
        SaveManager.instance.�����ܤƨƥ� += ��s;
        ��s();
    }
    private void OnDisable()
    {
        SaveManager.instance.�����ܤƨƥ� -= ��s;
    }
    [SerializeField] Text ScoreText = null;
    [SerializeField] Text HighScoreText = null;
    void ��s()
    {
        // �N���ƥ�000,000,000���覡���
        ScoreText.text = "Score = " + SaveManager.instance.Score.ToString("N0");
        HighScoreText.text = "HighScore = " + SaveManager.instance.HighScore.ToString("N0");
    }
    private void Update()
    {
        if (SaveManager.instance.HighScore < SaveManager.instance.Score)
        {
            SaveManager.instance.HighScore = SaveManager.instance.Score;
        }
    }
}