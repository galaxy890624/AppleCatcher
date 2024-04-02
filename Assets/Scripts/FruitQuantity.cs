using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FruitQuantity : MonoBehaviour
{
    // 從Item調用數量的文字
    // 參考 DoorObject.cs
    [SerializeField, Header("水果資料")]
    private Item FruitData;
    public int FruitCount = 8; // 水果種類數量
    [SerializeField, Header("水果數量文字")]
    private Text[] QuantityText = new Text[5];
    private string PlayerName = "獵人";
    private void Update()
    {
        //DoorSkill = SkillManager.Instance.RandomSkill;
        // 技能名稱 = 變形.取得第1個子物件 的 第1個子物件 取得它的TMPU
        //TextSkill = transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        //TextSkill.text = DoorSkill.SkillName;
    }


    /*
    void Start()
    {
        SaveManager.instance.AppleQuantity變化事件 += 刷新;
        刷新();
    }
    private void OnDisable()
    {
        SaveManager.instance.AppleQuantity變化事件 -= 刷新;
    }
    [SerializeField] Text AppleQuantityText = null;
    void 刷新()
    {
        AppleQuantityText.text = SaveManager.instance.AppleQuantity.ToString("N0");
    }*/

    /*public class DoorObject : MonoBehaviour
    {
        [SerializeField, Header("門的技能")]
        private DataSkill DoorSkill;
        [SerializeField, Header("技能名稱")]
        private TextMeshProUGUI TextSkill;
        private string PlayerName = "獵人";

        private void Awake()
        {
            DoorSkill = SkillManager.Instance.RandomSkill;
            // 技能名稱 = 變形.取得第1個子物件 的 第1個子物件 取得它的TMPU
            TextSkill = transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
            TextSkill.text = DoorSkill.SkillName;
        }
        private void OnTriggerEnter(Collider other)
        {
            // 如果 碰到物件的名稱 是 玩家
            if (other.name.Contains(PlayerName))
            {
                // print($"<color=#ff00ff>玩家碰到了<color=#00ff00></color></color>");
                SkillManager.Instance.UpgradeSkill(DoorSkill);
            }
        }
    }*/
}