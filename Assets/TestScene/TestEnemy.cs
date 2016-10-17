using UnityEngine;
using System.Collections;

public class TestEnemy : MonoBehaviour
{
    public Transform target;
    public TestHealthScript healthLoss;
    public int moveSpeed;
    public int rotationSpeed;
    public int maxdistance;
    private Transform myTransform;
    //------------------------------------//    

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {

        maxdistance = 2;
    }


    void Update()
    {


        if (Vector3.Distance(target.position, myTransform.position) > maxdistance)
        {
            //Move towards target
            transform.LookAt(target.position);
            
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

        }
    }
}
