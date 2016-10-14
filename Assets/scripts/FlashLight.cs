using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour
{

    Light spotLight;

    public bool lightOn;

    public AudioSource soundOn;
    public AudioSource soundOff;

	// Use this for initialization
	void Start ()
    {
        spotLight = GetComponent<Light>();

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Mouse1))
        {
            lightOn = !lightOn;
        }
                
        if(lightOn)
        {
            spotLight.enabled = true;
            soundOn.Play();
            
        }

        else if(!lightOn)
        {
            spotLight.enabled = false;
            soundOff.Play();
        }
    }  
}
