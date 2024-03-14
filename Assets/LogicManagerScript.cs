using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;


    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++; 
        string v = playerScore.ToString();
        scoreText.text = v; 
    }
}
