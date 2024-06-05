using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FMODUnity;

public class ScoreController : MonoBehaviour
{
    //[serializedfield] private EventReference ScoreUp;
    public static ScoreController instance;

    public Text scoreText;
    public Text highscoreText;

    public int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Points: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
        //AudioManager.instance.PlayOneShot(ScoreUp);
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
