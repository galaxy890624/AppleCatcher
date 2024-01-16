using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // [SerializeField] UnityEvent 按鈕點擊音效 = null;

    public void 開始()
    {
        Debug.Log("開始");
        SceneManager.LoadScene("GamePlay");
    }

    public void 升級()
    {
        Debug.Log("升級");
        SceneManager.LoadScene("TechnologyTree");

    }
    public void 選項()
    {
        Debug.Log("選項");
    }
    public void 離開()
    {
        Debug.Log("離開");
    }
    public void 返回Menu()
    {
        Debug.Log("返回Menu");
        SceneManager.LoadScene("Menu");
    }
}