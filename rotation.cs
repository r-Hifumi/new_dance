using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour
{


    public void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {


            //����ת
            //transform����ǰ����
            transform.Rotate(Vector3.right * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {


            //����ת
            transform.Rotate(Vector3.left * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //����ת
            transform.Rotate(Vector3.up * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //����ת
            transform.Rotate(Vector3.down * Time.deltaTime * 30);
        }


    }
    //ˢ����ת��ʼλ�÷���������ʼλ���������ã�


}
