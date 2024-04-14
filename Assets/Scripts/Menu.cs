
using UnityEngine;
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
        Application.Quit(); // 在 Unity 內點離開遊戲是不會有作用, 需要發佈PC或者手機, 主機執行檔
    }
    public void 返回Menu()
    {
        Debug.Log("返回Menu");
        SceneManager.LoadScene("Menu");
    }
}