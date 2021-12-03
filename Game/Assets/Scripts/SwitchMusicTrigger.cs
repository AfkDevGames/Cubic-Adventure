using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchMusicTrigger : MonoBehaviour
{//Nova muzika za nov area
    public AudioClip newTrack;

    private AudioManagerScr theAM;

     void Start()
    {
       // theAM = FindObjectOfType<AudioManagerScr>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (newTrack != null)
            {
                theAM = FindObjectOfType<AudioManagerScr>();
                theAM.ChangeBGM(newTrack);
            }
        }
    }
    

}
