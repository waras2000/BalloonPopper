using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class PlayAudioOnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    //public AudioSlider volume;
    public AudioSource AudioSource;
    private AudioMixer Mixer;
    public AudioClip music;
    private void Awake(){
        //GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        //volume = FindObjectOfType<AudioSlider>();
        //AudioSource.volume=PlayerPrefs.GetFloat("Volume",0f);
        //AudioSource.volume=0;
        //AudioSource = GetComponent<AudioSource>();
        AudioSource.volume=PlayerPrefs.GetFloat("Volume",0f);
        AudioSource.Play();
        //music.Play();

    }
}
