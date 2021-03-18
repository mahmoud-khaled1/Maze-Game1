using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMusicSound : MonoBehaviour
{
    
    private AudioSource audioSrc;
    private float musicVolume = 1f;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        audioSrc.volume = musicVolume;
    }

    // Method that is called by slider game object
    // This method takes vol value passed by slider
    // and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
