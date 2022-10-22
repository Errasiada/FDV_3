using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 _goal;
    
    void Start()
    {
       
    }
    
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, _goal, speed * Time.deltaTime);
        
        this.transform.Translate(_goal.normalized * (speed * Time.deltaTime));
        
        
        // Despegue
        
        transform.position = transform.position + new Vector3(1 * speed * Time.deltaTime,1 * speed * Time.deltaTime, 0);
        
        
        Debug.Log(transform.position);
    }
}
