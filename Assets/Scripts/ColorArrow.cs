using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorArrow : MonoBehaviour
{
    [SerializeField] private Image im;
    BetController bc;

    void Start()
    {
        bc = GameObject.Find("amountBet").GetComponent<BetController>();
    }

    void Update()
    {
        switch (bc.bet)
        {
            case "black":
                im.color = new Color(255, 255, 255, 255);
                transform.localPosition = new Vector2(-573f, 410f);
                break;
            case "red":
                im.color = new Color(255, 255, 255, 255);
                transform.localPosition = new Vector2(-471f, 410f);
                break;
            case "green":
                im.color = new Color(255, 255, 255, 255);
                transform.localPosition = new Vector2(-365f, 410f);
                break;
            default:
                im.color = new Color(255, 255, 255, 0);
                break;
        }
    }
}
