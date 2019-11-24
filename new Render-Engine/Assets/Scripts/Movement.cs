using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float mvSpeed = 10;
    public float speedH = 2;
    public float speedV = 2;

    private float yaw = 0;
    private float pitch = 0;

    private float xAxis;
    private float zAxis;
    private float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0);

        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");

        ySpeed = 0;

        if (Input.GetKey(KeyCode.Space))
            ySpeed = 1;
        else if (Input.GetKey(KeyCode.LeftShift))
            ySpeed = -1;

        transform.Translate(new Vector3(xAxis * mvSpeed * Time.deltaTime, ySpeed * mvSpeed * Time.deltaTime, zAxis * mvSpeed * Time.deltaTime));
    }
}
