using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleQuantity : MonoBehaviour
{
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
    }
}