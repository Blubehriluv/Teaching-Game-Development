using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = tf.position + Vector3.left * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            tf.position = tf.position + Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            if (FloorManager.jumps != 0)
            {
                rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);
                FloorManager.jumps -= 1;
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
