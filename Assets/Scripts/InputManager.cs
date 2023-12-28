
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InputManager : MonoBehaviour
{
    public static InputManager S;
    public GameObject cube;
    public Vector3 localPosition;
    public GameObject GameManger;
    public CSharpForGIT csharpForGIT;
    int pan;
    float value = 0;
    public int count = 0;
    Image image;
    private void Awake()
    {
        S = this;
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(GameManger.GetComponent<CSharpForGIT>().receivedPos); //assigning receivedPos in SendAndReceiveData()
        if (GameManger.GetComponent<CSharpForGIT>().varity != 0 && count == 0)
        {
            value = GameManger.GetComponent<CSharpForGIT>().varity / 120;
            Debug.Log(value);
            count = 1;
        }
        if (!GameManager.isDancing)
            return;

        if (UIManager.S.CheckPointerIsInSweetSpot())
        {
            pan = GameManger.GetComponent<ArrowManager>().panduan;
            if ((cube.transform.rotation.x < value - 0.3 && pan == 0) || (cube.transform.rotation.x > value + 0.3 && pan == 1))
            {
                UIManager.S.pointerMoveSpeed *= 1.07f;
                ArrowManager.S.TypeArrow();
                GameManager.S.FinishWave();
            }
            else
            {
                GameManager.S.FailWave();
            }
        }
    }
}
