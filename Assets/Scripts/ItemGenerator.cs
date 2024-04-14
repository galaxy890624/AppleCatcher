
using UnityEngine;


// 用來控制Item的生成

public class ItemGenerator : MonoBehaviour
{
    public Item Item;
    public Transform Parent; // Content

    #region singleton
    // 可以在其他代碼進行訪問
    static ItemGenerator instance;
    public ItemManager ItemManager;
    public GameObject[] FruitLevel = null; // 所有水果的Prefabs
    public float[] FruitQuantity = new float[8]; // 所有水果的數量
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

/*
 * public class FruitGenerator : MonoBehaviour
{
    [Header("水果等級")] // 必須由 Lv 0 排到 Lv 7
    public GameObject[] FruitLevel = null; // 所有水果的Prefabs
    // Vector3 InitialPosition;
    [Header("左邊界"), Tooltip("這是水果出現最左邊的位置限制")]
    public float LimitLeft = -9.5f;
    [Header("右邊界"), Tooltip("這是水果出現最右邊的位置限制")]
    public float LimitRight = 9.5f;
    [Header("生成水果的位置")]
    public Transform Generator;
    int random = 0;
    float SpawnTime = 0f; // 生成水果的計時器

    // Game logic
    private void Update()
    {
        if (Time.time > SpawnTime)
        {
            random = UnityEngine.Random.Range(0, 3); // 隨機生成 Lv0 ~ Lv2 的水果
            Generator.position = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
            Instantiate(FruitLevel[random], Generator.position, Quaternion.identity);
            SpawnTime += 1f; // Delay 1秒
        }
    }
}
 */