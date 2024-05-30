using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class FlyJoystick : MonoBehaviour
{
    public float speed = 2.5f; 
    public float speedAmplifier = 1.5f;
    public float rotationSpeed = 10.5f;

    public GameObject player;
    public XRJoystick joystick; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float virtualRoll = joystick.value.x;
        float virtualPitch = joystick.value.y;

        float inputYaw = Input.GetAxis("Yaw");

        player.transform.Rotate(virtualPitch * rotationSpeed * Time.deltaTime, 
                              virtualRoll * rotationSpeed * Time.deltaTime,
                              virtualRoll * -rotationSpeed * Time.deltaTime );

        player.transform.Translate(Vector3.forward * speed );


    }
}
