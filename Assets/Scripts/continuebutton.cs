using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class continuebutton : MonoBehaviour
{
    private Button button;
    private PauseManager pauseManager;

    void Start()
    {
        button = GetComponent<Button>();
        pauseManager = GameObject.Find("GameManager").GetComponent<PauseManager>();
        button.onClick.AddListener(OffClick);
    }

    void OffClick()
    {
        if (pauseManager != null)
        {
            pauseManager.ResumeGame();

        }
    }
}