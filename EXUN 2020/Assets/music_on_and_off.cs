using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_on_and_off : MonoBehaviour
{
    bool isMusicPlaying = true;
    [SerializeField] GameObject musicPlayer;
    [SerializeField] GameObject musicStrikeThrough;

    public void toggleMusic()
    {
        if(isMusicPlaying)
        {
            isMusicPlaying = false;
            musicPlayer.GetComponent<AudioSource>().enabled = false;
            musicStrikeThrough.SetActive(true);
        }
        else if(isMusicPlaying == false)
        {
            isMusicPlaying = true;
            musicPlayer.GetComponent<AudioSource>().enabled = true;
            musicStrikeThrough.SetActive(false);
        }
    }
    
}
