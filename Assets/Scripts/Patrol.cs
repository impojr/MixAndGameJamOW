using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;
    public float playerDetect = 10f;
    public Transform player;

    private bool movingRight = true;

    public Transform groundDetection;

    private Animator anim;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        int layer_mask = LayerMask.GetMask("Ground");
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector3.down, distance, layer_mask);

        if(groundInfo.collider == false)
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
