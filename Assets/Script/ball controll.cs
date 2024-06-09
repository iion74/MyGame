using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroll : MonoBehaviour
{
    // 볼 가속도
    public float BallInitialVelocity = 1f;
    // 리지디바디
    private Rigidbody ballRigidBody = null;
    //볼플레이 선택여부
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
