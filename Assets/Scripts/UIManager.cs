using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager S;
    private void Awake()
    {
        S = this;
    }

    public Text levelText;
    public Transform pointer, sweetSpot;
    public Transform startPos, endPos;
    public int a=2;
    public float pointerMoveSpeed;

    private void Start()
    {
        pointerMoveSpeed = (endPos.position.x - startPos.position.x) / (60f / GameManager.S.bpm * 8f);
        a = a *2;
    }

    private void Update()
    {
        pointer.position += Vector3.right * pointerMoveSpeed * Time.deltaTime;

        if (pointer.position.x > endPos.position.x)
            ResetPointer();
    }

    void ResetPointer()
    {
        pointer.position = startPos.position;
        GameManager.S.PointerIsReset();
    }

    public void ShowOrHidePointer()
    {
        pointer.gameObject.SetActive(!pointer.gameObject.activeInHierarchy);
    }

    public bool CheckPointerIsInSweetSpot()
    {
        return Mathf.Abs((pointer.position.x - sweetSpot.position.x)) < 25f;
    }

    public void RenewLevelText(int level)
    {
        levelText.text = "SCORE " + level;
    }
}
