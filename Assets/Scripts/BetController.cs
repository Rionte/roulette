using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using EasyUI.PickerWheelUI;

public class BetController : MonoBehaviour
{
    [SerializeField] public float totalBet;
    [SerializeField] public string bet;
    [SerializeField] public TextMeshProUGUI buttonText;
    [SerializeField] private CoinController cc;
    [SerializeField] private PickerWheel wheel;

    void Update()
    {
        if (!wheel.IsSpinning)
        {
            buttonText.text = totalBet.ToString();
        }
    }
}
