using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    //proba izmedju
    public Sound[] sounds;
    public AudioSource source;
    public AudioClip clip;
    //proba izmedju
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    
    public GameObject optionsMenuUI;
   
    
    void Start()
    {
        pauseMenuUI.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            //I did this - unload options from game,back to pause screen when pressing escape
            else if (optionsMenuUI.activeSelf)
                
            {
                UnloadOptionsMenu(); 
            }
            else
            {
                Pause();
                source.Stop();
                source.PlayOneShot(clip);
                //source.PlayOneShot(clip);

            }
        }
        //try


        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                Resume();
                Restart();
            }
            else
            {
                Restart();
            }

        }
        
        //try
    }


    //proba izmedju
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
        if (s == null)
        {
            return;
        }
        //proba izmedju
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        //proba
        //source.PlayOneShot(clip);
        //proba

    }
    public void LoadMenu()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    public void LoadOptionsMenu()
    {
        GameIsPaused = true;
        Time.timeScale = 0f;
    }
    public void UnloadOptionsMenu()
    {
        //I did this - unload options from game,back to pause screen
        optionsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0f;
    }
    //try
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //try
   


}
