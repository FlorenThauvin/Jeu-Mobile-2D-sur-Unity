using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsWindow : MonoBehaviour
{
    public AudioMixer audioMixer;
    public bool muted;
  
    public void SetVolume(float volume) 
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void MuteVolume()
    {
        if (muted)
        {
            audioMixer.SetFloat("volume", 0);
            muted = false;
        }
        else
        {
            audioMixer.SetFloat("volume", -80);
            muted = true;
        }
    }
}
