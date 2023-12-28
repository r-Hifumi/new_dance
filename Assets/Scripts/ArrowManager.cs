
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    public static ArrowManager S;
    private void Awake()
    {
        S = this;
    }

    public GameObject arrowPrefab;
    public Transform arrowsHolder;
    public static bool isFinish;
    Queue<Arrow> arrows = new Queue<Arrow>();
    Arrow currentArrow;
    int randomDir;
    public int panduan;

    public void CreateWave(int length)
    {
        arrows = new Queue<Arrow>();
        isFinish = false;
        Arrow arrow = Instantiate(arrowPrefab, arrowsHolder).GetComponent<Arrow>();
        randomDir = Random.Range(0, 2);
        panduan = randomDir;
        arrow.Setup(randomDir);
        arrows.Enqueue(arrow);
        currentArrow = arrows.Dequeue();
    }
    public void TypeArrow()
    {
       
            //Type Correctly
            currentArrow.SetFinish();
                isFinish = true;
        
    }

    public void ClearWave()
    {
        arrows = new Queue<Arrow>();
        foreach (Transform arrow in arrowsHolder)
        {
            Destroy(arrow.gameObject);
        }
    }

    int ConvertKeyCodeToInt(KeyCode key)
    {
        int result = 0;
        switch (key)
        {

            case KeyCode.LeftArrow:
                {
                    result = 0;
                    break;
                }
            case KeyCode.RightArrow:
                {
                    result = 1;
                    break;
                }
        }

        return result;
    }
}
