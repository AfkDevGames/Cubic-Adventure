using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Audio;
using UnityEngine.UI;

public class EscBackMainMenu : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject OptionsMainUI;
    public GameObject DifficultyMainUI;
    public GameObject ControlsIntendedUI;
    public GameObject ControlsBabyUI;
   

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (OptionsMainUI.activeSelf)
            {
                UnloadOptionsUI();
            }
            else if (DifficultyMainUI.activeSelf)
            {
                UnloadDiffUI();
            }
            else if (ControlsIntendedUI.activeSelf)
            {
                UnloadIntendedUI();
            }
            else if (ControlsBabyUI.activeSelf)
            {
                UnloadBabyUI();
            }
           
        }
    }
    public void UnloadOptionsUI()
    {
                
        OptionsMainUI.SetActive(false);
        MainMenuUI.SetActive(true);
        

    }
    public void UnloadDiffUI()
    {

        DifficultyMainUI.SetActive(false);
        MainMenuUI.SetActive(true);

    }
    public void UnloadIntendedUI()
    {

        ControlsIntendedUI.SetActive(false);
        DifficultyMainUI.SetActive(true);

    }
    public void UnloadBabyUI()
    {

        ControlsBabyUI.SetActive(false);
        DifficultyMainUI.SetActive(true);

    }

}
