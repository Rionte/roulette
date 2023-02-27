using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.PickerWheelUI;

public class CoinController : MonoBehaviour
{
    [SerializeField] public float coins = 0;
    [SerializeField] private BetController bc;
    [SerializeField] private PickerWheel wheel;

    void Start()
    {
        bc = GameObject.Find("amountBet").GetComponent<BetController>();

        wheel.OnSpinStart(() =>
        {
            bc.buttonText.text = "0";
        });

        wheel.OnSpinEnd(result =>
        {
            if (bc.bet == result.Icon.name)
            {
                switch (bc.bet)
                {
                    case "black":
                        coins += bc.totalBet * 2;
                        break;
                    case "red":
                        coins += bc.totalBet * 2;
                        break;
                    case "green":
                        coins += bc.totalBet * 12;
                        break;
                }
            }

            bc.totalBet = 0;
        });
    }

    public void addCoins(float amount)
    {
        coins += amount;
    }

    public void removeCoins(float amount)
    {
        coins -= amount;
    }

    public void setCoins(float amount)
    {
        coins = amount;
    }
}
