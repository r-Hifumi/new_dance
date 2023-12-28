using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class startgame : MonoBehaviour
{
    private Music_Controller music_Controller;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        music_Controller = GameObject.Find("Music").GetComponent<Music_Controller>();
        button.onClick.AddListener(click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void click()
    {
        Time.timeScale = 1;
        music_Controller.PlayAudio();
    }
}
