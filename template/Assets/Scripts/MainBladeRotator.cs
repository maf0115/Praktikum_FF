using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBladeRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate( new Vector3(0, 720, 0) * Time.deltaTime);
    }
}
