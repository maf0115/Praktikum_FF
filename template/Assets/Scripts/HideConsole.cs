using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events; 

public class AddTurbo : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas console;  
    public AudioClip clickSound;
    private bool isDisabled = false;
     

    public void ActivateTurbo()
    {
        isDisabled = !isDisabled;
        Debug.Log( "isDisabled: " + isDisabled );

        AudioSource.PlayClipAtPoint( clickSound, transform.position, 1 );
        console.enabled = isDisabled; 
    }

    void Start()
    {
        clickSound = GetComponent<AudioClip>();
        console = GetComponent<Canvas>();
        GetComponent<XRSimpleInteractable>().selectExited.AddListener(x => ActivateTurbo()); 
        
    }
}
