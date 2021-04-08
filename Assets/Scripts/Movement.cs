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
        ProcessInput();
    }

    void ProcessInput()
    {
       if (Input.GetKey(KeyCode.Space))
       {
           myRigidbody.AddForce(0f, thrustForceY * Time.deltaTime, 0f);
       }
    }
}
