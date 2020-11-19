using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_on_and_off : MonoBehaviour
{
    bool isMusicPlaying = true;
    singleton musicPlayer;
    [SerializeField] GameObject musicStrikeThrough;


    void Start()
    {
        musicPlayer = FindObjectOfType<singleton>();
        isMusicPlaying = musicPlayer.enabled;
        musicStrikeThrough.SetActive(!isMusicPlaying);
    }
    private void Update()
    {
        musicStrikeThrough.SetActive(!isMusicPlaying);
    }
    public void toggleMusic()
    {
        musicPlayer = FindObjectOfType<singleton>();
        if (isMusicPlaying)
        {
            isMusicPlaying = false;
            musicPlayer.GetComponent<AudioSource>().enabled = false;

        }
        else if(isMusicPlaying == false)
        {
            isMusicPlaying = true;
            musicPlayer.GetComponent<AudioSource>().enabled = true;

        }
    }
    
}
