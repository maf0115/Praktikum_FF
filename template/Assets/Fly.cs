using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Fly : MonoBehaviour
{ 
    float speed = 5f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        //Rotation to the left
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, 0, -speed) * Time.deltaTime);   
        }

        //Rotation to the right
        if (Input.GetKey(KeyCode.D))
        {

            this.transform.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);

        }
    }
}
