using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffects : MonoBehaviour
{
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip hit;
    [SerializeField] AudioClip trampoline;
    [SerializeField] AudioClip checkPoint;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void playAudio(sfx audio)
    {
        if(audio == sfx.jump)
        {
            audioSource.PlayOneShot(jump, 1);
        }
        if (audio == sfx.hit)
        {
            audioSource.PlayOneShot(hit, 1);
        }
        if (audio == sfx.trampoline)
        {
            audioSource.PlayOneShot(trampoline, 1);
        }
        if (audio == sfx.checkpoint)
        {
            audioSource.PlayOneShot(checkPoint, 1);
        }
    }
}
