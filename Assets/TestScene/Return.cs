using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
<<<<<<< develop
    public string levelToLoad = "";

    // Use this for initialization
    void Start ()
=======

	// Use this for initialization
	void Start ()
>>>>>>> Failed Stuff
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnMainMenuDown()
    {
<<<<<<< develop
        Application.LoadLevel(levelToLoad);
=======
        SceneManager.LoadScene("Dmoney", LoadSceneMode.Additive);
>>>>>>> Failed Stuff
    }
}
