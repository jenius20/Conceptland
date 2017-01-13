using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private bool gameOver = false;
    private float score = 0.0f;
    private static float highScore = 0.0f;

    public float pointsPerUnitTravelled = 1.0f;
    public float gameSpeed = 20.0f;

	// Use this for initialization
	void Start ()
    {
        Instance = this;
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
        score += pointsPerUnitTravelled * gameSpeed * Time.deltaTime;
        if (score < highScore)
        {
            highScore = score;
        }





    }

    void OnGUI()
    {
        int currentHighscore = (int)highScore;
        int currentScore = (int)score;
        GUILayout.Label("Score " + currentScore.ToString());
        GUILayout.Label("Highscore: " + currentScore.ToString());

        if (gameOver == true)
        {
            GUILayout.Label("Game Over! Press any key to reset!");
        }
    }
}
