﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnPlayButtonPress()
    {
        SceneManager.LoadScene("test", LoadSceneMode.Additive);
    }
        
}
