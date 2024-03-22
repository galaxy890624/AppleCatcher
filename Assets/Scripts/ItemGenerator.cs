using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �Ψӱ���Item���ͦ�

public class ItemGenerator : MonoBehaviour
{
    public Item Item;
    public Transform Parent; // Content

    #region singleton
    // �i�H�b��L�N�X�i��X��
    static ItemGenerator instance;
    public ItemManager ItemManager;
    public GameObject[] FruitLevel = null; // �Ҧ����G��Prefabs
    public float[] FruitQuantity = new float[8]; // �Ҧ����G���ƶq
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
        // �T�O Item �w�g�Q��Ҥ�
        if (Item == null)
        {
            // ��Ҥ� Item
            Item = ScriptableObject.CreateInstance<Item>();
        }
    }

    public void ���ͤ��G()
    {
        // �O�o�bContent�[�WVertical Layout Group����, ��l����y����w��
        // Instantiate(ChatboxModule_0, Vector3.zero, Quaternion.identity, Parent);
        // print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }

}

/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �Ψӱ���Chatbox���ͦ�

public class ChatboxGenerator : MonoBehaviour
{
    public Chatbox Chatbox;
    public Transform Parent;

    #region singleton
    // �i�H�b��L�N�X�i��X��
    static ChatboxGenerator instance;
    public ChatboxManager ChatboxManager;
    public Text ItemInfo;
    public GameObject ChatboxModule_0; // ��誺��ܮؼҲ�
    public GameObject ChatboxModule_1; // �ۤv����ܮؼҲ�

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
        // �T�O Chatbox �w�g�Q��Ҥ�
        if (Chatbox == null)
        {
            // ��Ҥ� Chatbox
            Chatbox = ScriptableObject.CreateInstance<Chatbox>();
        }
    }

    public void ���͹�ܮ�0()
    {
        // �O�o�bContent�[�WVertical Layout Group����, ��l����y����w��
        Instantiate(ChatboxModule_0, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
    public void ���͹�ܮ�1()
    {
        // �O�o�bContent�[�WVertical Layout Group����, ��l����y����w��
        Instantiate(ChatboxModule_1, Vector3.zero, Quaternion.identity, Parent);
        print($"<color=#ff00ff>Info:<color=#00ff00>{Chatbox.Info}</color></color>");
    }
}
*/

/*
 * public class FruitGenerator : MonoBehaviour
{
    [Header("���G����")] // ������ Lv 0 �ƨ� Lv 7
    public GameObject[] FruitLevel = null; // �Ҧ����G��Prefabs
    // Vector3 InitialPosition;
    [Header("�����"), Tooltip("�o�O���G�X�{�̥��䪺��m����")]
    public float LimitLeft = -9.5f;
    [Header("�k���"), Tooltip("�o�O���G�X�{�̥k�䪺��m����")]
    public float LimitRight = 9.5f;
    [Header("�ͦ����G����m")]
    public Transform Generator;
    int random = 0;
    float SpawnTime = 0f; // �ͦ����G���p�ɾ�

    // Game logic
    private void Update()
    {
        if (Time.time > SpawnTime)
        {
            random = UnityEngine.Random.Range(0, 3); // �H���ͦ� Lv0 ~ Lv2 �����G
            Generator.position = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
            Instantiate(FruitLevel[random], Generator.position, Quaternion.identity);
            SpawnTime += 1f; // Delay 1��
        }
    }
}
 */