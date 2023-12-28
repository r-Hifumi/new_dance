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
        //��ͣ��Ƶ
        audioSource.Pause();
    }
    public void UnPauseAudio()
    {
        //����������Ƶ
        audioSource.UnPause();
    }
    public void PlayAudio()
    {
        audioSource.Play();
    }
}
