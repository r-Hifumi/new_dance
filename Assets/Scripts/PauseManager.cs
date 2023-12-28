using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
    private Music_Controller music_Controller;
    void Start()
    {
        music_Controller= GameObject.Find("Music").GetComponent<Music_Controller>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
             
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        music_Controller.PauseAudio();
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        SceneManager.UnloadScene(2);
        music_Controller.UnPauseAudio();
        isPaused = false;
    }
}
