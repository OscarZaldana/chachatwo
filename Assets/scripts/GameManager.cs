using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject startScreen;
    public GameObject options;
    public GameObject extraScreen;
    public GameObject creditScreen;
    public GameObject flashlight;
    public GameObject quit;

    public AudioClip impact;
    AudioSource click;

    // Use this for initialization
    void Start ()
    {
        click = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnPlayButtonPress()
    {
        click.PlayOneShot(impact, 0.7F);
        mainMenu.SetActive(false);
        SceneManager.LoadScene("tony", LoadSceneMode.Additive);
    }

    public void OnOptionPress()
    {
        click.PlayOneShot(impact, 0.7F);
        startScreen.SetActive(false);
        options.SetActive(true);
    }

    public void OnFlashLightPress()
    {
        click.PlayOneShot(impact, 0.7f);
    }

    public void OnExtraPress()
    {
        click.PlayOneShot(impact, 0.7F);
        startScreen.SetActive(false);
        extraScreen.SetActive(true);
    }
    public void OnReturnPress()
    {
        click.PlayOneShot(impact, 0.7F);
        options.SetActive(false);
        extraScreen.SetActive(false);
        startScreen.SetActive(true);
    }

    public void OnCreditPress()
    {
        click.PlayOneShot(impact, 0.7F);
        startScreen.SetActive(false);
        creditScreen.SetActive(true);
    }
    public void OnQuitPress()
    {
        click.PlayOneShot(impact, 0.7F);
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

}
