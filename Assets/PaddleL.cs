using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleL : MonoBehaviour
{
    public Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * Time.deltaTime * 10000);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * Time.deltaTime * 10000);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
