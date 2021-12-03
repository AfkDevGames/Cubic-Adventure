using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
       public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadCreditsScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Credits");
    }

}
