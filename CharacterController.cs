using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 1f;
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime,0, verticalInput * speed * Time.deltaTime);
     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed *= 2;
        }
    }
}
