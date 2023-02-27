using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Music") == null)
        {
            BackgroundMusic newAudio = Instantiate(this);
            newAudio.tag = "Music";
            newAudio.GetComponent<AudioSource>().volume = 1;
            newAudio.name = "BackgroundMusic";
            DontDestroyOnLoad(newAudio);
            Destroy(this);
        }
    }
}