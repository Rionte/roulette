using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private AudioClip muteSound;
    [SerializeField] private AudioClip unmuteSound;
    [SerializeField] private AudioSource playSound;
    AudioSource auds;

    void Start()
    {
        auds = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();

        button.onClick.AddListener(() =>
        {
            if (auds.volume == 0)
            {
                playSound.PlayOneShot(unmuteSound, 0.25f);
                button.GetComponent<Image>().color = new Color(0, 0, 0);
                auds.volume = 1;
            }
            else
            {
                playSound.PlayOneShot(muteSound, 0.25f);
                button.GetComponent<Image>().color = new Color(255, 255, 0);
                auds.volume = 0;
            }
        });
    }
}
