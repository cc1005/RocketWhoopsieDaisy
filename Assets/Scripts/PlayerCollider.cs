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

        switch (other.gameObject.tag)
        {
            case "Environment":
                myRigidbodyCollider.constraints = RigidbodyConstraints.None;
                break;
            case "Obstacle":
                myRigidbodyCollider.constraints = RigidbodyConstraints.None;
                otherRigidbodyCollider.useGravity = true;
                break;
            default:
                Debug.Log("This is a default collision");
                break;
        }
    }

}
