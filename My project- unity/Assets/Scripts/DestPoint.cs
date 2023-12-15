using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestPoint : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform destPoint;
    private Animator anim;
    private bool hasReachedDestination = false;

    void Start()
    {
        anim = GetComponent<Animator>();

        if (destPoint == null)
        {
            Debug.LogError("Destiny Error.");
            enabled = false; 
        }
    }

    void Update()
    {
        if (!hasReachedDestination)
        {
            transform.position = Vector3.MoveTowards(transform.position, destPoint.position, speed * Time.deltaTime);

           
            if (transform.position == destPoint.position)
            {
                Debug.Log("The animal reach destiny.");
                hasReachedDestination = true;

                
                if (anim != null)
                {
                    anim.enabled = false; 
                }
            }
        }
    }
}
