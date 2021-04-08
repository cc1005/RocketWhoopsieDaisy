using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    Rigidbody myRigidbodyCollider;
void Start()
    {
        myRigidbodyCollider = GetComponent<Rigidbody>();
    }

private void OnCollisionEnter(Collision other) 
    {
        myRigidbodyCollider.useGravity = true;
    }
}
