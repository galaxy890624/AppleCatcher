using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ψ��x�s���G����T
// ex: ���G�ʵe, index, �o��, ...
// �Ѧ�Chatbox.cs

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")] // �k�� > Item > New Item

public class Item : ScriptableObject
{
    public int Index;
    public string ItemName;
    public Sprite ItemImage; // �Y���Ϥ�
    public int GetScore; // �Y���o�쪺����
    public float ItemQuantity; // �����ƶq

}