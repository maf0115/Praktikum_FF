using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed = 1.2f; 
    public float speedAmplifier = 1.5f;
    public float rotationSpeed = 4.5f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputPitch = Input.GetAxis("Pitch");
        float inputYaw = Input.GetAxis("Yaw");
        float inputRoll = Input.GetAxis("Roll");
        float inputSpeed = Input.GetAxis("Throttle") - speedAmplifier * Time.deltaTime;

        this.transform.Rotate(inputPitch * rotationSpeed * Time.deltaTime, 
                              inputYaw * rotationSpeed * Time.deltaTime,
                              inputRoll * rotationSpeed * Time.deltaTime );

        this.transform.Translate(Vector3.back * inputSpeed);


    }
}
