using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
    

public class TestHealthScript : MonoBehaviour
{
    public float health = 100f;
    private float startingHealth;
    public float healthDecrease = 5.0f;
    
    public Renderer staticRenderer;

	// Use this for initialization
	void Start ()
    {
        startingHealth = health;

        GameObject staticObject = GameObject.Find("StaticObject");

        if(staticObject)
        {
            staticRenderer = staticObject.GetComponent<Renderer>();

            staticRenderer.material.color = new Color(0, 0, 0, 0);
        }
        else
        {
            Debug.LogWarning("Oops! Not here!");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        LoseHealth();
	}

    void LoseHealth()
    {
        float healthDecay = startingHealth / healthDecrease;

        //health -= healthDecay * Time.deltaTime;

        float newAlpha = 1.0f - health / startingHealth;

        staticRenderer.material.color += new Color(1, 1, 1, newAlpha);

        if (health <= 0)
        {
            Debug.Log("I died! :(");
        }
    }
}
