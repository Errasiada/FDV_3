using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Vector3;
using UnityEditor.UIElements;

public class CharacterController : MonoBehaviour
{
    public float speed = 1f;
    public static int score = 0;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0,
            verticalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed *= 2;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.CompareTag("capsule"))
        {
            score += 1;
        }
    }
}
