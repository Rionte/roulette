using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private AudioSource playSound;
    [SerializeField] private AudioClip clip;
    CoinController cc;
    BetController bc;
    string buttonName;

    void Start()
    {
        cc = GameObject.Find("CoinController").GetComponent<CoinController>();
        bc = GameObject.Find("amountBet").GetComponent<BetController>();
        buttonName = transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>().text;
        playSound = GameObject.Find("buttonSounds").GetComponent<AudioSource>();
        clip = playSound.clip;

        button.onClick.AddListener(() =>
        {
            playSound.PlayOneShot(clip, 0.3f);

            if (int.TryParse(buttonName, out int value))
            {
                if (buttonName[0] == "-".ToCharArray()[0])
                {
                    if ((bc.totalBet >= 0) && (bc.totalBet + value >= 0))
                    {
                        bc.totalBet += value;
                        cc.removeCoins(value);
                    }
                }
                else
                {
                    if ((cc.coins >= 0) && (cc.coins - value >= 0))
                    {
                        bc.totalBet += value;
                        cc.removeCoins(value);
                    }
                }
            }
            else
            {
                switch (buttonName)
                {
                    case "+1/2":
                        if ((cc.coins >= 0) && (cc.coins - cc.coins / 2 >= 0))
                        {
                            bc.totalBet += Mathf.Floor(cc.coins / 2);
                            cc.removeCoins(Mathf.Floor(cc.coins / 2));
                        }
                        break;
                    case "MAX":
                        bc.totalBet += cc.coins;
                        cc.setCoins(0);
                        break;
                }

                if ((transform.name == "black") || (transform.name == "red") || (transform.name == "green"))
                {
                    bc.bet = transform.name;
                }

                switch (transform.name)
                {
                    case "reset":
                        cc.addCoins(bc.totalBet);
                        bc.totalBet = 0;
                        break;
                    case "back":
                        SceneManager.LoadScene("SampleScene");
                        break;
                }

            }
        });
    }
}