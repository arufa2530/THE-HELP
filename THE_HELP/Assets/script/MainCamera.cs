using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetMainCamera : MonoBehaviour
{
    float inputHorizontal;
    float inputVertical;

    Rigidbody rd;

    float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        //
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        //
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;
        //
        rd.velocity = moveForward * moveSpeed + new Vector3(0, rd.velocity.y, 0);
        //
        if(moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }

}
