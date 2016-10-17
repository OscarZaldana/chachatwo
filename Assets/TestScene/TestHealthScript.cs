using UnityEngine;
using System.Collections;

public class TestHealthScript : MonoBehaviour
{
    public int health = 100;

    public Renderer staticRenderer;

	// Use this for initialization
	void Start ()
    {
        GameObject staticObject = GameObject.Find("StaticObject");

        if(staticObject)
        {
            staticRenderer = staticObject.GetComponent<Renderer>();
        }
        else
        {
            Debug.LogWarning("Oops! Not here!");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
