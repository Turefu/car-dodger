using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    private float speed = 7.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //  Move veihicle forward

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move vehicle forward based on forwardInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);        

        // Move vehicle forward based on horizontalInput
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
    
}
