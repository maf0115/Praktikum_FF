using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject player;
    public float distance;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + player.transform.forward * distance + player.transform.right * distance/3;

       this.transform.rotation = player.transform.rotation; 
    }
}
