using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    Rigidbody myRigidbodyCollider;
    Rigidbody otherRigidbodyCollider;

void Start()
    {
        myRigidbodyCollider = GetComponent<Rigidbody>();
    }

private void OnCollisionEnter(Collision other) 
    {
        otherRigidbodyCollider = other.gameObject.GetComponent<Rigidbody>();

        if (other.gameObject.tag != "LaunchPad")
        {
            myRigidbodyCollider.constraints = RigidbodyConstraints.None;
            Debug.Log("I should have no constraints");
            if (other.gameObject.tag == "Obstacle")
            {
                otherRigidbodyCollider.useGravity = true;
            }
        }
    }

}
