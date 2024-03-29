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
    /// <summary>
    /// public List<�C���A> �C��W��
    /// �C���, "List<>"������ƫ��A �����M "�Q�n���w��.cs�ɮ�" �@�P
    /// ex:
    /// public List<Item> itemList = new List<Item>();
    /// </summary>
    public List<Item> itemList = new List<Item>();
}