using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 1f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // MOVEMENT
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
        
        // Utilizar Spacebar para incrementar velocidad

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed *= 2;
        }
    }
}
