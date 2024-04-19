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
        this.transform.position = player.transform.position + distance * player.transform.forward + distance/4 * player.transform.right + distance/10 * player.transform.up;

       this.transform.rotation = player.transform.rotation; 
    }
}
