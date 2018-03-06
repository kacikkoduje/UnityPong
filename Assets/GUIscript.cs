using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIscript : MonoBehaviour {
    public Rigidbody2D Rb;
    // Use this for initialization
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick()
    {

        Debug.Log("You have clicked the button!");
        Rb.transform.position = new Vector3(0, 0, 0);
        Rb = GetComponent<Rigidbody2D>();
        int rand = Random.Range(0, 2);
        int angle = Random.Range(5, -5);
        if (rand == 0)
        {
            Rb.AddForce(Vector2.left * Time.deltaTime * 300);
            Rb.AddForce(new Vector2(0, angle) * Time.deltaTime);
        }
        else if (rand == 1)
        {
            Rb.AddForce(Vector2.right * Time.deltaTime * 300);
            Rb.AddForce(new Vector2(0, angle) * Time.deltaTime);
        }
    }
}
