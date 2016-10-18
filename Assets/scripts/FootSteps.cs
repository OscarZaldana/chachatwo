using UnityEngine;
using System.Collections;

public class FootSteps : MonoBehaviour
{
    CharacterController cc;

    public AudioSource footSteps;


	// Use this for initialization
	void Start ()
    {
        cc = GetComponent<CharacterController>();
       // footSteps = FindObjectOfType<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(cc.isGrounded == true && cc.velocity.magnitude > 2f && footSteps.isPlaying == false)
        {
            footSteps.Play();
        } 
	}
}
