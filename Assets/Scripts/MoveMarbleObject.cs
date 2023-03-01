using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarbleObject : MonoBehaviour
{
    public float movementSpeed = 10; 
    public Transform[] pathEdge = new Transform[2];
    private int index = 0;
    private float maxDist = 0.5f;
    private Transform prevDest;

    private void Start()
    {
        prevDest = pathEdge[0];
    }
    void Update()
    {

        if (Vector3.Distance(prevDest.position, transform.position)> maxDist+0.1f)
        {
            prevDest = pathEdge[index];
        }
        else
        {
            index++;
            if (index >= pathEdge.Length)
            {
                index = 0; //wrap around
            }
            prevDest = pathEdge[index]; //update to next point

            
        }
        transform.position = Vector3.MoveTowards(transform.position, prevDest.position,Time.deltaTime* maxDist * movementSpeed);
    }
}
