using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    public Sprite[] arrowSprites;
    Image image;

    [HideInInspector]
    public int arrowDir;

    public Color finishColor;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void Setup(int dir)
    {
        arrowDir = dir;
        image.sprite = arrowSprites[dir];
        image.SetNativeSize();
    }

    public void SetFinish()
    {
        image.color = finishColor;
    }
}
