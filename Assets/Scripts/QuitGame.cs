using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuitGame : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.AddListener(() => {
            Application.Quit();
        });
    }
}
