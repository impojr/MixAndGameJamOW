using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGroundDetection : MonoBehaviour
{
    public Patrol AI;

    private void OnTriggerEnter(Collider other)
    {
        //AI.isGrounded = true;
    }
}
