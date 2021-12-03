using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SliderYay : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.GetFloat("musicVolume");
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            //PlayerPrefs.GetFloat("musicVolume");
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    

  public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        //volumeSlider.GetComponent<Slider>().value = volumeSlider.value;
        Save();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        //try
       // volumeSlider.GetComponent<Slider>().value = volumeSlider.value;
        //try
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
        //try
        //volumeSlider.GetComponent<Slider>().value = volumeSlider.value;
        //try
    }
}
