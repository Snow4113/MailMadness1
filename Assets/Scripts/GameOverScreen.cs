using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] public GameObject gameOverScreen;

    public Text pointsText;
    public void Setup(int score)
    {
        pointsText.text = " POINTS" + score.ToString();
    }

    private void Awake()
    {
        gameOverScreen.SetActive(false);
    }

    public void RestartButton()
    {

    }

    public void QuitButton()
    {
        
    }

    internal static void Setup(bool v)
    {
        throw new NotImplementedException();
    }

    
}
