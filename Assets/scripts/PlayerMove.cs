using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;
    CharacterController player;
   // public float sensitivity = 2f;

    float moveFB;
    float moveLR;

    public bool isPaused = false;

    public GameObject pauseMenu;

    public string levelToLoad = "";

    // public GameObject eyes;

    //float rotX;
    //float rotY;


    // Use this for initialization
    void Start ()
    {
        player = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;

        //rotX = Input.GetAxis("Mouse X") * sensitivity;
      // rotY = Input.GetAxis("Mouse Y") * sensitivity;

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
      // transform.Rotate(0, rotX, 0);
      //  eyes.transform.Rotate(-rotY, 0, 0);

        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);

        PauseGame();
        
        
        Time.timeScale = isPaused ? 0 : 1;
    }

    void PauseGame()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pauseMenu.SetActive(true);
            isPaused = true;
            AudioListener.volume = 0;
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            pauseMenu.SetActive(false);
            isPaused = false;
            AudioListener.volume = 1;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isPaused)
        {
            AudioListener.volume = 1;
            Application.LoadLevel(levelToLoad);
        }
    }
}
