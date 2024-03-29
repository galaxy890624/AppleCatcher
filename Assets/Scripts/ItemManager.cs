using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

// �I�]�t��
// �Ψӱ���Item���x�s
// �Ѧ�ChatboxManager.cs

[CreateAssetMenu(fileName = "ItemManager", menuName = "Item/ItemManager")] // �k�� > Chatbox > ChatboxManager

public class ItemManager : ScriptableObject
{
    #region singleton
    public static ItemManager Instance;

    /// <summary>
    /// �H���ޯ���
    /// </summary>
    public Item RandomFruit => FruitLevel[Random.Range(0, FruitLevel.Length)];

    [SerializeField, Header("���G����FruitLevel")]
    private Item[] FruitLevel = null;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    

}