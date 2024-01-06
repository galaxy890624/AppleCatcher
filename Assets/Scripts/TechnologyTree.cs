using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TechnologyTree : MonoBehaviour
{
    public void 離開()
    {
        Debug.Log("離開科技樹");
        SceneManager.LoadScene("Menu");
    }
}
