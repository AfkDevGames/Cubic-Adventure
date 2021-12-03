using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManagerScr : MonoBehaviour
{
    
    public AudioSource BGM;
    //proba
   // public Slider volumeSlider;
    public static AudioManagerScr instance;
    //public AudioClip[] soundtrack;
    //public Sound[] sounds;
    //public static AudioManagerScr instance;
    // public static MusicPlayer instance;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        if(FindObjectsOfType<AudioManagerScr>().Length > 1)
        {
            Destroy(gameObject);
        }

    }


    //da probam
    /*
    void OnEnable()
    {
        //Register Slider Events
        volumeSlider.onValueChanged.AddListener(delegate { changeVolume(volumeSlider.value); });
    }

    //Called when Slider is moved
    void changeVolume(float sliderValue)
    {
        BGM.volume = sliderValue;
    }

    void OnDisable()
    {
        //Un-Register Slider Events
        volumeSlider.onValueChanged.RemoveAllListeners();
    }*/
    //da probam iznad

    /* void Awake()
     {

         if (instance == null)
             instance = this;
         else
         {
             Destroy(gameObject);
             return;
         }
         DontDestroyOnLoad(gameObject);

         foreach (Sound s in sounds)
         {
             s.source = gameObject.AddComponent<AudioSource>();
             s.source.clip = s.clip;

             s.source.volume = s.volume;
             s.source.pitch = s.pitch;
             s.source.loop = s.loop;
         }
     }
     public void Stop(string name)
     {
         Sound s = Array.Find(sounds, sound => sound.name == name);
         s.source.Stop();
         if (s == null)
         {
             return;
         }

     }
     //ovo gore izmedju probam
    */
    public void ChangeBGM(AudioClip music)
    {
        if (BGM.clip.name == music.name)
            return;

        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
        //try
        if( SceneManager.GetActiveScene().name !=("PreMenu"))
        BGM.loop = true;
        
        
    }

}
