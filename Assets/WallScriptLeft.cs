using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WallScriptLeft : MonoBehaviour
{
    public Text textCounter;
    public int points;
    public GameObject Object;
    public int PointCount;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisplayCounter();
    }

    private void DisplayCounter()
    {
        this.textCounter.text = string.Format(": {0}",this.PointCount/2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PointCount++;
        points++;
        if (points == 1)
        {
            Debug.Log(points);
            restartCurrentScene();
            points = 0;
        }
        else
        {
            return;
        }
    }
    public void restartCurrentScene()
    {
        Object.transform.position = new Vector3(0, 0, 0);
    }
}