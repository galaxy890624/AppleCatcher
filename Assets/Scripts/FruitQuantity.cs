using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FruitQuantity : MonoBehaviour
{
    // �qItem�եμƶq����r
    // �Ѧ� DoorObject.cs
    [SerializeField, Header("���G���")]
    private Item FruitData;
    public int FruitCount = 8; // ���G�����ƶq
    [SerializeField, Header("���G�ƶq��r")]
    private Text[] QuantityText = new Text[5];
    private string PlayerName = "�y�H";
    private void Update()
    {
        //DoorSkill = SkillManager.Instance.RandomSkill;
        // �ޯ�W�� = �ܧ�.���o��1�Ӥl���� �� ��1�Ӥl���� ���o����TMPU
        //TextSkill = transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        //TextSkill.text = DoorSkill.SkillName;
    }


    /*
    void Start()
    {
        SaveManager.instance.AppleQuantity�ܤƨƥ� += ��s;
        ��s();
    }
    private void OnDisable()
    {
        SaveManager.instance.AppleQuantity�ܤƨƥ� -= ��s;
    }
    [SerializeField] Text AppleQuantityText = null;
    void ��s()
    {
        AppleQuantityText.text = SaveManager.instance.AppleQuantity.ToString("N0");
    }*/

    /*public class DoorObject : MonoBehaviour
    {
        [SerializeField, Header("�����ޯ�")]
        private DataSkill DoorSkill;
        [SerializeField, Header("�ޯ�W��")]
        private TextMeshProUGUI TextSkill;
        private string PlayerName = "�y�H";

        private void Awake()
        {
            DoorSkill = SkillManager.Instance.RandomSkill;
            // �ޯ�W�� = �ܧ�.���o��1�Ӥl���� �� ��1�Ӥl���� ���o����TMPU
            TextSkill = transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
            TextSkill.text = DoorSkill.SkillName;
        }
        private void OnTriggerEnter(Collider other)
        {
            // �p�G �I�쪫�󪺦W�� �O ���a
            if (other.name.Contains(PlayerName))
            {
                // print($"<color=#ff00ff>���a�I��F<color=#00ff00></color></color>");
                SkillManager.Instance.UpgradeSkill(DoorSkill);
            }
        }
    }*/
}