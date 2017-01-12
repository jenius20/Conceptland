using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOver = true;
        }
        if (gameOver)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); ;
            }
        }
		
	}

    void OnGUI()
    {
        if(gameOver == true)
        {
            GUILayout.Label("Game Over! Press any key to reset!");
        }
    }
}
