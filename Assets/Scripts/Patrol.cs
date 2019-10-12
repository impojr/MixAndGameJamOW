using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true;
    public bool isGrounded;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(!isGrounded)
        {
            if(movingRight)
            {
                transform.eulerAngles = new Vector3(0, 180);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

}
