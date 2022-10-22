using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 goal;
    public float accuracy = 0.01f;
    public float speed;

    private void Start()
    {
        transform.LookAt(goal);
    }

    void Update()
    {
        Vector3 direction = goal - transform.position;
        this.transform.Translate(direction.normalized * (speed * Time.deltaTime), Space.World);
        if (direction.magnitude > accuracy) ;
        {
            transform.Translate(direction.normalized * (speed * Time.deltaTime));
        }
        Debug.DrawRay(transform.position,direction,Color.magenta);
    }
}
