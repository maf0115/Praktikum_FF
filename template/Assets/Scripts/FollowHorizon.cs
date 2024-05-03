using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHorizon : MonoBehaviour
{
    public GameObject ground; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = ground.transform.rotation;
        this.transform.Rotate( -90, 180, -90 ); 
    }
}
