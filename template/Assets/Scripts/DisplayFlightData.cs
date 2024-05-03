using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class DisplayFLightData : MonoBehaviour
{
    public TextMeshProUGUI textSpeed;
    public TextMeshProUGUI textHeigth;
    public GameObject player;
    public float warningHeigth = 100;
    public GameObject warnImage;
    public GameObject OkImage; 
    private FlyJoystick flyJoystick;

    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
    }

    // Update is called once per frame
    void Update()
    { 
        textHeigth.SetText( "Alt: {0:2}ft", player.transform.position.y * 3.28f);

        //This one needs to be fixed!!!
        textSpeed.SetText( "Speed: {0:1}km/h", Input.GetAxis( "Throttle" ) + (flyJoystick.speedAmplifier * Time.deltaTime ) * 100f ) ;


        if(player.transform.position.y <= warningHeigth)
        {
            warnImage.SetActive( true );
            OkImage.SetActive( false );
        }
        else
        {
            warnImage.SetActive( false );
            OkImage.SetActive( true );
            }
        }
    }

