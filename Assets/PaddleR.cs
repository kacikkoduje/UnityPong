using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleR : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * Time.deltaTime * 50);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector2.down * Time.deltaTime * 50);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.zero;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
