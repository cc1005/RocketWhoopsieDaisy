using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float thrustForceY = 100f;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
       if (Input.GetKey(KeyCode.Space))
       {
           myRigidbody.AddForce(0f, thrustForceY * Time.deltaTime, 0f);
       }
    }
    
    void ProcessRotation()
    {
       if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
       {
           Debug.Log("Rotate left!");
       }
       else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
       {
           Debug.Log("Rotate right!");
       }
    }
}