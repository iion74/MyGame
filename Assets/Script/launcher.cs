using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour
{
    public float launcherSpeed = 1f; // launcher의 이동속도
    private Vector3 playerPos = new Vector3(0f, -3.5f, 0f); // launcher의 초기 위치

   
    void Update()
    {
        // launcher의 좌우이동
        float xPos = transform.position.x + (Input.GetAxis("Horizontal")* launcherSpeed);
        // launcher의 이동제한
        playerPos = new Vector3(Mathf.Clamp(xPos,-2f,2f), -3.5f, 0f);
        transform.position = playerPos;
    }
}
