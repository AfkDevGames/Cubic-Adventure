using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SorryScript : MonoBehaviour
{
    public GameObject sorry;
    public float delay = 4;
    
    void Start()
    {
        //sorry.SetActive(false);
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        
        yield return new WaitForSeconds(delay);
        sorry.SetActive(true);
    }
}
