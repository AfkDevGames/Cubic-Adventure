using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 15f;
    //try
    public GameOverScreen GameOverScreen;
    int scoreValue = 0;
    public PauseMenu pauseMenu;
    public static bool GameIsPaused = false;
    //try
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //try
            GameOverScreen.Setup(scoreValue);
            //try
            Debug.Log("GAME OVER");
            //Invoke("Restart", restartDelay);
        }
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}

