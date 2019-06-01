using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    GameObject targetObj;

    Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetObj = GameObject.Find("TargetGameObject");
        targetPos = targetObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Following();
    }

    private void Following()
    {
        //
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

        //
        if(Input.GetMouseButton(1))
        {
            //
            float mouseInputX = Input.GetAxis("Mouse X");
            float mouseInputY = Input.GetAxis("Mouse Y");
            //
            transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200.0f);
            //
            transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 200.0f);
        }
    }
    
}
