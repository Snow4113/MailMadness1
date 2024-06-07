using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FMODUnity;

public class ScoreController : MonoBehaviour
{
<<<<<<< HEAD
    //[serializedfield] private EventReference ScoreUp;
=======
    [SerializeField] private EventReference ScoreUp;
    [SerializeField] public GameObject gameOver;
    public static ScoreController instance;
>>>>>>> 1232ae1a4caacbf574588484bbc39ddf9410ea19

    public Text scoreText;
    public Text highscoreText;

    public int score = 0;
    int highscore = 0;


    //public void GameOver()
    
        //GameOverScreen.Setup(score <= -5);
    

    public void Update()
    {
<<<<<<< HEAD
    }



    void Start()
=======
        if (score >= -5)
        {
            GameOverScreen(!gameOver.activeInHierarchy);
        }
    }
    public void GameOverScreen(bool status)
    {
        //If status == true pause | if status == false unpause
        gameOver.SetActive(status);
    }


        void Start()
>>>>>>> 1232ae1a4caacbf574588484bbc39ddf9410ea19
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
