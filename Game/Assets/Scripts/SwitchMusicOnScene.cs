using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SwitchMusicOnScene : MonoBehaviour
{
    public AudioClip newTrack;

    private AudioManagerScr theAM;

    void Start()
    {
        theAM = FindObjectOfType<AudioManagerScr>();

        if (newTrack != null)
        {
            theAM.ChangeBGM(newTrack);
        }
        
    }
    public void Update()
    {
        /*
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu1st"))
        {
            Destroy(this.gameObject);

        }*/
    }
}
