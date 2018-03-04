using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioSource src;
    public CircleCollider2D Col;
    public bool trigg;
    public Rigidbody2D rb;
    void Start()
    {
        Col = GetComponent<CircleCollider2D>();
        src = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            rb.AddForce(Vector2.left * Time.deltaTime * 300);
        }
        else if (rand == 1)
        {
            rb.AddForce(Vector2.right * Time.deltaTime * 300);
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        int rand = Random.Range(0, 2);
        rand = Random.Range(0, 2);

        src.Play(0);

        if (rand == 0)
        {
            rb.AddForce(Vector2.up * Time.deltaTime * 75);
        }

        if (rand == 1)
        {
            rb.AddForce(Vector2.down * Time.deltaTime * 75);
        }
    }

}