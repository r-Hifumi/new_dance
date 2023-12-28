using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    private Button button;
    private PauseManager pauseManager;

    void Start()
    {
        button = GetComponent<Button>();
        pauseManager = GameObject.Find("GameManager").GetComponent<PauseManager>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (pauseManager != null)
        {
            pauseManager.PauseGame();

        }
    }
}
