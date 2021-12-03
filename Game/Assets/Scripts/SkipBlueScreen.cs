using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipBlueScreen : MonoBehaviour
{
    public float delay = 5;
    public string NewLevel;
    public string RealLevel;

    void Start()
    {   
        // Ova linija koda ispod je samo za testiranje
        //PlayerPrefs.SetInt("FirstLaunch", 0);


            if (PlayerPrefs.GetInt("FirstLaunch") == 0)
            {
                //First launch
                PlayerPrefs.SetInt("FirstLaunch", 1);
                StartCoroutine(LoadLevelAfterDelay(delay));
        }
            else
            {
            //Load scene_02 if its not the first launch
            StartCoroutine(LoadRealLevelAfterDelay(delay));
        }

        

        /* if (PlayerPrefs.HasKey("HasDoneTutorial"))
         {
             SceneManager.LoadScene("Menu1st");
         }
         else
         {
             SceneManager.LoadScene("PreMenu");
         }*/
    }
    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
    IEnumerator LoadRealLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(RealLevel);
    }

}
