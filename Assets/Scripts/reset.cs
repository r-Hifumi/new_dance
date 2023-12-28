using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEditor;

public class reset : MonoBehaviour
{
    AsyncOperation operation1;
    private Music_Controller music_Controller;
    // Start is called before the first frame update
    void Start()
    {
        music_Controller = GameObject.Find("Music").GetComponent<Music_Controller>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator loadscene1()
    {
        operation1 = SceneManager.LoadSceneAsync(1);
        yield return operation1;
    }
    public void resetclick()
    {
        StartCoroutine(loadscene1());
        Time.timeScale = 0;

        
    }
}
