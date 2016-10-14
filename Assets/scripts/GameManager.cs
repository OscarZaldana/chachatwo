using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;

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
        mainMenu.SetActive(false);
        SceneManager.LoadScene("test", LoadSceneMode.Additive);
    }
        
}
