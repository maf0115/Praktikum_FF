using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SwitchScene : MonoBehaviour
{
    public string scene = "Cockpit";


    // Start is called before the first frame update
    void Start()
    {

    }

  

    // Update is called once per frame
    void Update()

    {
        Debug.Log(this.transform.rotation.y); 
        if (this.transform.rotation.y >= 0.65)
        {
            Debug.Log("Switching scene to " + scene);
            SceneManager.LoadScene(scene);
            
            
        }
    }
}
