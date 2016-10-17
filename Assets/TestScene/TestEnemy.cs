using UnityEngine;
using System.Collections;

public class TestEnemy : MonoBehaviour
{
    public Transform target;
    public TestHealthScript canSee;
    public int moveSpeed;
    public int rotationSpeed;
    public float maxdistance;
    private Transform myTransform;
    //------------------------------------//    

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {

        
    }


    void Update()
    {


        if (Vector3.Distance(target.position, myTransform.position) > maxdistance)
        {
            canSee.isSeen = true;
            //Move towards target
            transform.LookAt(target.position);
            
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

        }

        else
        {
            canSee.isSeen = false;
        }
    }
}
