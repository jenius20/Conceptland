using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private bool gameOver = false;
    private bool hasSaved = false;
    private float score = 0.0f;
    private static float highscore = 0.0f;

    public float pointsPerUnitTravelled = 1.0f;
    public float gameSpeed = 20.0f;

	// Use this for initialization
	void Start ()
    {
        Instance = this;
        LoadHighScore();
	}
	
	// Update is called once per frame
	void Update ()
    {
 

        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOver = true;
        }
        if(gameOver)
        {
            if(!hasSaved)
            {
                SaveHighscore();
                hasSaved = true;
            }
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); ;
            }
        }
 
        if (!gameOver)
        {
            score += pointsPerUnitTravelled * gameSpeed * Time.deltaTime;
            if(score > highscore)
            {
                highscore = score;
            }
        }




    }

    void SaveHighscore()
    {
        PlayerPrefs.SetInt("Highscore", (int)highscore);
        PlayerPrefs.Save();
    }

    void LoadHighScore()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    void OnGUI()
    {
        int currentHighscore = (int)highscore;
        int currentScore = (int)score;
        GUILayout.Label("Score " + currentScore.ToString());
        GUILayout.Label("Highscore: " + currentHighscore.ToString());

        if (gameOver == true)
        {
            GUILayout.Label("Game Over! Press any key to reset!");
        }
    }
}
