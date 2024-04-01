using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitQuantity : MonoBehaviour
{
    // 從Item調用數量的文字
    private void Update()
    {

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
}