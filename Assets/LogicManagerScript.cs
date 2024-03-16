using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject startGameScreen; 

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;  
        string v = playerScore.ToString();
        scoreText.text = v; 
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }


    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void playGame()
    {
        startGameScreen.SetActive(false); 
    }
    


}
