using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{

    public string levelToLoad = "";

    // Use this for initialization
    void Start ()
    {

    }


	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnMainMenuDown()
    {

        Application.LoadLevel(levelToLoad);

        SceneManager.LoadScene("Dmoney", LoadSceneMode.Additive);

    }
}
