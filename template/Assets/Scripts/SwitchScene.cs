using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SwitchScene : MonoBehaviour
{
    HingeJoint doorHinge;
    public string scene = "Cockpit"; 

    // Start is called before the first frame update
    void Start()
    {
        doorHinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.rotation.y > doorHinge.limits.max)
        {
            SceneManager.LoadScene(scene); 
        }
    }
}
