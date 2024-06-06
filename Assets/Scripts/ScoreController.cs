using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public GameOverScreen gameOverScreen;
    public static ScoreController instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    public void GameOver()
    {
        GameOverScreen.Setup(score <= -5);
    }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Points: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1; 
        scoreText.text = "Points: " + score.ToString();
    }

    public void RemovePoint()
    {
        score -= 1;
        scoreText.text = "Points: " + score.ToString();
    }
}
