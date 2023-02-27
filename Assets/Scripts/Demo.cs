using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyUI.PickerWheelUI;

public class Demo : MonoBehaviour
{
    [SerializeField] private PickerWheel pickerWheel;
    [SerializeField] private Button button;
    BetController bc;

    void Start()
    {
        bc = GameObject.Find("amountBet").GetComponent<BetController>();

        button.onClick.AddListener(() =>
        {
            if ((bc.bet != "") && (bc.totalBet > 0))
            {
                print(bc.bet);
                pickerWheel.Spin();
            }
        });
    }

    void Update()
    {
        
    }
}
