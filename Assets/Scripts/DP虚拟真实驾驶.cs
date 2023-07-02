// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DP虚拟真实驾驶 : MonoBehaviour
// {
//     public float speed = 5.0f;
//     public float angularSpeed = 1.0f;
    
//     private bool increaseSpeed = false;
//     private bool decreaseSpeed = false;
//     private bool turnLeft = false;
//     private bool turnRight = false;
//     public float acceleration = 5.0f;
//     public float drag = 4.0f;

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//     //  Move veihicle forward

//         HandleAcceleration();
//         ApplyDrag();
//         HandleTurn();

//         transform.Translate(Vector3.forward * Time.deltaTime * speed);

//     }

//     void HandleTurn(){

//         if(Input.GetKeyDown(KeyCode.A)){
//             turnLeft = true;
//         }

//         if(Input.GetKeyDown(KeyCode.D)){
//             turnRight = true;
//         }

//         if(Input.GetKeyUp(KeyCode.A)){
//             turnLeft = false;
//         }

//         if(Input.GetKeyUp(KeyCode.D)){
//             turnRight = false;
//         }

//         if(turnLeft){
//             transform.Rotate(Vector3.up, Time.deltaTime * -angularSpeed);
//         }

//         if(turnRight){
//             transform.Rotate(Vector3.up, Time.deltaTime * angularSpeed);
//         }
//     }

//     void HandleAcceleration(){

//         if(Input.GetKeyDown(KeyCode.W)){
//             increaseSpeed = true;
//         }

//         if(Input.GetKeyDown(KeyCode.S)){
//             decreaseSpeed = true;
//         }

//         if(Input.GetKeyUp(KeyCode.W)){
//             increaseSpeed = false;
//         }

//         if(Input.GetKeyUp(KeyCode.S)){
//             decreaseSpeed = false;
//         }

//         if(increaseSpeed){
//             speed = speed + (Time.deltaTime * acceleration);
//         }

//         if(decreaseSpeed){
//             speed = speed - (Time.deltaTime * acceleration);
//         }

//     }

//     void ApplyDrag(){
//         if(speed > (Time.deltaTime * drag)){
//             speed = speed - (Time.deltaTime * drag);
//         }

//         if(speed < -(Time.deltaTime * drag)){
//             speed = speed + (Time.deltaTime * drag);
//         }
//     }
// }
