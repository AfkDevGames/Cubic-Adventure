using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class SecretLVL : MonoBehaviour
{
    public float downTime, upTime, pressTime = 0;
    public float countDown = 7.0f;
    public bool ready = false;

    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public GameObject optionsMenu;

    private void Start()
    {
        //pauseMenu.SetActive(false);
        //gameOverMenu.SetActive(false);
    }



    void Update()
    {
        if (((Input.GetKeyDown(KeyCode.LeftArrow)) || (Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.D))) && (ready == false))
        {
            downTime = Time.time;
            pressTime = downTime + countDown;
            ready = true;
        }
        if (((Input.GetKeyUp(KeyCode.LeftArrow)) || (Input.GetKeyUp(KeyCode.RightArrow)) || (Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.D))))
        {
            ready = false;
        }
        if (Time.time >= pressTime && ready == true && !pauseMenu.activeSelf && !gameOverMenu.activeSelf && !optionsMenu.activeSelf)
        {
            ready = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
