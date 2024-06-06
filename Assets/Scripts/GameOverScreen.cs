using System;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS"; 

    }

    public void RestartButton() 
    { 
    
    }

    public void ExitButton() 
    { 
    
    }

    internal static void Setup(bool v)
    {
        throw new NotImplementedException();
    }
}
