using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerCheck : MonoBehaviour
{
    public GameObject audioMan;
    
    // Start is called before the first frame update
    void Start()
    {
        if(FindObjectOfType<AudioManagerScr>())
            return;
        else
            Instantiate(audioMan, transform.position, transform.rotation);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
