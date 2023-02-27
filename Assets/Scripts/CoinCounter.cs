using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyUI.PickerWheelUI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private PickerWheel wheel;
    [SerializeField] private CoinController cc;

    void Start()
    {
        text.text = cc.coins.ToString();
    }

    void Update()
    {
        text.text = cc.coins.ToString();
    }
}
