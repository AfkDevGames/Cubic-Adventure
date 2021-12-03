using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Konami2 : MonoBehaviour
{
    #region Public_Variables
    public List<KeyCode> keySequence = new List<KeyCode>();
    #endregion

    public GameObject tajMeni;
    public GameObject tajMeni2;

    public GameObject Manager;
    public GameObject ManagerR;
    public GameObject ManagerA;
    public GameObject ManagerD;


    #region Private_Variables
    private int _lastCorrectIndex;
    #endregion

    #region Unity_CallBacks
    // Update is called once per frame
    void Update()
    {
        if (keySequence.Count > 0 && ((tajMeni.activeSelf) || (tajMeni2.activeSelf)) && ((Manager.activeSelf && ManagerA.activeSelf && ManagerD.activeSelf && ManagerR.activeSelf)))
        {
            foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(vKey))
                {
                    if (vKey == (keySequence[_lastCorrectIndex]))
                    {
                        _lastCorrectIndex++;
                        if (_lastCorrectIndex == keySequence.Count)
                        {
                            KeySequenceMatched();
                        }
                    }
                    else
                    {
                        _lastCorrectIndex = 0;
                    }
                }
            }
        }
    }

    #endregion

    #region Private_Methods

    void KeySequenceMatched()
    {
        _lastCorrectIndex = 0;
        Debug.Log("Key Sequence Matched");
        //do your stuff
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    #endregion
}
