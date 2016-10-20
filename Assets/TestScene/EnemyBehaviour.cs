using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{
    public PlayerHealth player;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            player.isSeen = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            player.isSeen = false;
        }
    }
}
