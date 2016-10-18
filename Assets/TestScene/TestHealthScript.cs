using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
    

public class TestHealthScript : MonoBehaviour
{
    public GameObject gameOver;

    public float health = 100f;
    private float startingHealth;
    
    public float healthDecrease = 5.0f;

    public bool isSeen = false;
    public bool healing = false;
    public bool isDead = false;
    
    public Renderer staticRenderer;


	// Use this for initialization
	void Start ()
    {
        startingHealth = health;

        GameObject staticObject = GameObject.Find("StaticObject");

        if(staticObject)
        {
            staticRenderer = staticObject.GetComponent<Renderer>();

            staticRenderer.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
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
        RegenHealth();
	}

    void LoseHealth()
    {
        if(isSeen && !isDead)
        {
            float healthDecay = startingHealth / healthDecrease;
            health -= healthDecay * Time.deltaTime;
            float newAlpha = 1.0f - (health / startingHealth);
            staticRenderer.material.color = new Color(1.0f, 1.0f, 1.0f, newAlpha);
        }
        if(health <= 0)
        {
            gameOver.SetActive(true);
            isDead = true;
        }
    }
    void RegenHealth()
    {
        if(!isSeen && health < startingHealth && !isDead)
        {
            healing = true;
            if(healing)
            {
                float healthDecay = startingHealth / healthDecrease;
                health += healthDecay * Time.deltaTime;
                float newAlpha = -1.0f + (health / startingHealth);
                staticRenderer.material.color = new Color(1.0f, 1.0f, 1.0f, newAlpha);
            }
            else if (health <= 100)
            {
                healing = false;
                Start();
            }
        }
    }
}
