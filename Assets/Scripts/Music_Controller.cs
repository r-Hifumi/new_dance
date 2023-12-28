using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void PauseAudio()
    {
        //‘›Õ£“Ù∆µ
        audioSource.Pause();
    }
    public void UnPauseAudio()
    {
        //ºÃ–¯≤•∑≈“Ù∆µ
        audioSource.UnPause();
    }
    public void PlayAudio()
    {
        audioSource.Play();
    }
}
