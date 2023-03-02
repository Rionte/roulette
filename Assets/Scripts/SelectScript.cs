using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SelectScript : MonoBehaviour
{
    void Start()
    {
        transform.Find("button").GetComponent<Button>().onClick.AddListener(() =>
        {
            switch (transform.name)
            {
                case "roulette":
                    SceneManager.LoadScene("Game");
                    break;
            }
        });
    }
}
