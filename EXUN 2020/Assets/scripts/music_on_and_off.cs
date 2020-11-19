using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_on_and_off : MonoBehaviour
{
    bool isMusicPlaying = true;
    singleton musicPlayer;
    [SerializeField] GameObject musicStrikeThrough;

    private void Update()
    {
        musicPlayer = FindObjectOfType<singleton>();
        isMusicPlaying = musicPlayer.GetComponent<AudioSource>().enabled;
        musicStrikeThrough.SetActive(!isMusicPlaying);

    }
    public void toggleMusic()
    {
        musicPlayer = FindObjectOfType<singleton>();
        if (isMusicPlaying)
        {
            isMusicPlaying = false;
            musicPlayer.gameObject.GetComponent<AudioSource>().enabled = false;
            isMusicPlaying = musicPlayer.GetComponent<AudioSource>().enabled;
        }
        else if(isMusicPlaying == false)
        {
            isMusicPlaying = true;
            musicPlayer.gameObject.GetComponent<AudioSource>().enabled = true;
            isMusicPlaying = musicPlayer.GetComponent<AudioSource>().enabled;
        }
    }
    
}
