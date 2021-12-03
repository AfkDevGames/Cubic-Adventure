using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioPause : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
         source.PlayOneShot(clip);
        }
    }
}
