using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour {
    public int points;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        points++;
        if (points == 3)
        {
            Debug.Log(points);
            restartCurrentScene();
        }
        else
        {
            return;
        }
    }
    public void restartCurrentScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
