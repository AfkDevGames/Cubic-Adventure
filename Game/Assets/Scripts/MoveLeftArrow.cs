using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MoveLeftArrow : MonoBehaviour
{
    public GameObject Manager;
    public GameObject ManagerR;
    public GameObject ManagerA;
    public GameObject ManagerD;
    // Start is called before the first frame update
    void Start()
    {
        

        Manager.SetActive(true);
        ManagerR.SetActive(false);
        ManagerA.SetActive(false);
        ManagerD.SetActive(false);

    }
     void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.L))
        {
            if (Manager.activeSelf)
            {
                Manager.SetActive(false);
            }
            else
            {
                Manager.SetActive(true);
            }
           
        }*/
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ManagerR.activeSelf)
            {
                ManagerR.SetActive(false);
            }
            else
            {
                ManagerR.SetActive(true);
            }

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (ManagerA.activeSelf)
            {
                ManagerA.SetActive(false);
            }
            else
            {
                ManagerA.SetActive(true);
            }

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ManagerD.activeSelf)
            {
                ManagerD.SetActive(false);
            }
            else
            {
                ManagerD.SetActive(true);
            }

        }
    }
}

    // Update is called once per frame
   /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            MoveUIElements.enabled = !MoveUIElements.enabled;
    }
}*/
