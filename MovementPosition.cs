using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPosition : MonoBehaviour
{
    public Vector3 goal;
    public float accuracy = 0.01f;
    public float speed;
    
    void Update()
    {
        Vector3 direction = goal - transform.position;
        this.transform.Translate(direction.normalized * (speed * Time.deltaTime));
        if (direction.magnitude > accuracy) ;
        {
            transform.Translate(direction.normalized * (speed * Time.deltaTime));
        }
    }
}
