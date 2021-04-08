using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float thrustForceY = 1000f;
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
           myRigidbody.AddRelativeForce(Vector3.up * thrustForceY * Time.deltaTime);
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