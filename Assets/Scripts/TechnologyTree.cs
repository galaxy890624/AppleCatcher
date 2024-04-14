
using UnityEngine;
using UnityEngine.SceneManagement;

public class TechnologyTree : MonoBehaviour
{
    public void 離開()
    {
        Debug.Log("離開科技樹");
        SceneManager.LoadScene("Menu");
    }
}
