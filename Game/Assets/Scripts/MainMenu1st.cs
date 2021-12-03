using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1st : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void PlayBaby()
    {
        SceneManager.LoadScene(3);
    }

}
