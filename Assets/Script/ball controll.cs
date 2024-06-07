using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroll : MonoBehaviour
{
    public float BallInitialVelocity = 300f;
    private Rigidbody ballRigidBody = null;
    private bool isBallInplay = false;
    private void Awake()
    {
        ballRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && !isBallInplay)
        {
            transform.parent = null;
            isBallInplay = true;
            ballRigidBody.isKinematic = false;
            ballRigidBody.AddForce(new Vector3(BallInitialVelocity, BallInitialVelocity, 0f));
        }
    }
}
