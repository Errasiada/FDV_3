using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public CharacterController character;
   
    void Start()
    {
        character = GetComponent<CharacterController>(); 
    }
    
    void Update()
    {
        Vector3 move;
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}
