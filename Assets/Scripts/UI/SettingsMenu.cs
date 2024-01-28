using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : AbstractMenu
{
    public AudioMixer AudioMixer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Back()
    {
        GoToParent();
    }

    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("MasterVol", volume);

    }
}
