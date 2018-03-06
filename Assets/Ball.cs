using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    public AudioSource src;
    public CircleCollider2D Col;
    public bool trigg;
    public Rigidbody2D rb;
    public int time;

    void Start()
    {
        Col = GetComponent<CircleCollider2D>();
        src = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        int rand;
        int angle;
        rand = Random.Range(0, 2);
        angle = Random.Range(5, -5);
        rb.velocity = new Vector2(0, 0);
        if (rand == 0)
        {
            rb.AddForce(Vector2.left * Time.deltaTime * 900);
            rb.AddForce(new Vector2(0, angle) * Time.deltaTime * 50);
        }
        else if (rand == 1)
        {
            rb.AddForce(Vector2.right * Time.deltaTime * 900);
            rb.AddForce(new Vector2(0, angle) * Time.deltaTime * 50);
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        src.Play(0);
    }

    void Update()
    {
        time++;
        print(time);

        float velx = rb.velocity.x;
        float vely = rb.velocity.y;

        print(vely);

        if (velx >= 4 || velx <= -4)
        {
            print("Velx = >4");
            transform.position = new Vector3(0, 0, 0);
            rb.velocity = new Vector2(0, 0);
            //Start();
        }
    }

    public void restartScene()
    {
        transform.position = new Vector3(0, 0, 0);
        rb.velocity = new Vector2(0, 0);
        Start();
    }
}
