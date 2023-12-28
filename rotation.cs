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


            //向上转
            //transform代表当前对象
            transform.Rotate(Vector3.right * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {


            //向下转
            transform.Rotate(Vector3.left * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //向左转
            transform.Rotate(Vector3.up * Time.deltaTime * 30);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //向右转
            transform.Rotate(Vector3.down * Time.deltaTime * 30);
        }


    }
    //刷新旋转起始位置方法（将起始位置重新设置）


}
