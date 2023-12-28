using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager S;
    private void Awake()
    {
        S = this;
    }

    int currentLevel = 0;
    public static bool isDancing;

    //
    public Animator anim;
    public int bpm;
    public float startDelay;
    public AudioSource au;
    public GameObject enemydied;
    public GameObject end1;
    public GameObject end2;
    public GameObject end3;
    public GameObject playerobject;
    public GameObject rotation;
    public int end;
    int flag = 0;

    private void Start()
    {
        NextWave();
        //
        Invoke("PlaySound", startDelay);
    }

    void PlaySound()
    {
        au.Play();
    }

    void NextWave()
    {
        UIManager.S.ShowOrHidePointer();
        UIManager.S.RenewLevelText(currentLevel);

        ArrowManager.S.CreateWave(currentLevel);
        isDancing = true;
    }

    public void FinishWave()
    {

        rotation.transform.localEulerAngles = new Vector3(0, 0, 0);
        flag = 0;
        currentLevel++;
        isDancing = false;
        ArrowManager.S.ClearWave();
        UIManager.S.ShowOrHidePointer();
        anim.SetFloat("Dance", Random.Range(0.01f, 1f));

    }

    public void FailWave()
    {
        rotation.transform.localEulerAngles = new Vector3(0, 0, 0);
        end++;
        flag = 1;
        isDancing = false;
        ArrowManager.S.ClearWave();
        UIManager.S.ShowOrHidePointer();
        rotation.transform.localEulerAngles = new Vector3(0, 0, 0);
        //
        anim.SetFloat("Dance", -0.01f);
    }

    public void PointerIsReset()
    {
        if (isDancing)
            FailWave();
        else
        {
            if (end == 3 && flag == 1)
            {
                Destroy(end1);
                Instantiate(enemydied, end1.transform.position, Quaternion.identity);
                flag = 0;
            }
            if (end == 4 && flag == 1)
            {
                Destroy(end2);
                Instantiate(enemydied, end2.transform.position, Quaternion.identity);
                flag = 0;
            }
            if (end == 5 && flag == 1)
            {
                SceneManager.LoadScene(3);
            }

            NextWave();
        }
    }
}
