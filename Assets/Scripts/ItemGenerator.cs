using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 用來控制Item的生成

public class ItemGenerator : MonoBehaviour
{
    public Item Item;
    public Transform Parent;

    #region singleton
    // 可以在其他代碼進行訪問
    static ItemGenerator instance;
    public ItemManager ChatboxManager;
    public GameObject[] FruitLevel = null; // // 所有水果的Prefabs
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }
    #endregion

    // initialize
    private void OnEnable()
    {
        // 確保 Item 已經被實例化
        if (Item == null)
        {
            // 實例化 Item
            Item = ScriptableObject.CreateInstance<Item>();
        }
    }

    public void 產生水果()
    {
        // 記得在Content加上Vertical Layout Group元件, 把子物件座標鎖定住
        // Instantiate(ChatboxModule_0, Vector3.zero, Quaternion.identity, Parent);
        // print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }

}

/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 用來控制Chatbox的生成

public class ChatboxGenerator : MonoBehaviour
{
    public Chatbox Chatbox;
    public Transform Parent;

    #region singleton
    // 可以在其他代碼進行訪問
    static ChatboxGenerator instance;
    public ChatboxManager ChatboxManager;
    public Text ItemInfo;
    public GameObject ChatboxModule_0; // 對方的對話框模組
    public GameObject ChatboxModule_1; // 自己的對話框模組

    //public List<GameObject> Slots = new List<GameObject>();

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }
    #endregion

    // initialize
    private void OnEnable()
    {
        // 確保 Chatbox 已經被實例化
        if (Chatbox == null)
        {
            // 實例化 Chatbox
            Chatbox = ScriptableObject.CreateInstance<Chatbox>();
        }
    }

    public void 產生對話框0()
    {
        // 記得在Content加上Vertical Layout Group元件, 把子物件座標鎖定住
        Instantiate(ChatboxModule_0, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
    public void 產生對話框1()
    {
        // 記得在Content加上Vertical Layout Group元件, 把子物件座標鎖定住
        Instantiate(ChatboxModule_1, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
}
*/