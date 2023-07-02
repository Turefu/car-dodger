using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 精神过敏原加的代码，会在inspection加可调参数栏—————public float speed;
    public float speed  = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move vehicle forward
        // transform.Translate(0, 0, 0);
        // transform.Translate(0, 0.1f, 0.1f);
        // transform.Translate(Vector3.up);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}