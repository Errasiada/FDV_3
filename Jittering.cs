using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Jittering : MonoBehaviour
{
    public float speed;
    public Vector3 goal;
    public float accuracy = 0.01f;
    
    void Update()
    {
        Vector3 direction = goal - transform.position;
        if (direction.magnitude > accuracy) ;
        {
            transform.Translate(direction.normalized * (speed * Time.deltaTime));
        }
        
    }
}
