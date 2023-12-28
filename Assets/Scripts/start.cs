using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEditor;

public class start : MonoBehaviour
{
    AsyncOperation operation;
    private Music_Controller music_Controller;
    // Start is called before the first frame update
    void Start()
    {
        music_Controller = GameObject.Find("Music").GetComponent<Music_Controller>();
    }
    IEnumerator loadscene()
    {
        operation = SceneManager.LoadSceneAsync(1);
        yield return operation;
    }
    public void Startclick()
    {
        StartCoroutine(loadscene());

        Time.timeScale = 0;
    }
}
