using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
public class AudioSlider : MonoBehaviour
{
    [SerializeField]
    private AudioMixer Mixer;
    [SerializeField]
    private AudioSource AudioSource;
    [SerializeField]
    private TextMeshProUGUI ValueText;
    [SerializeField]
    public AudioMixMode MixMode;
    
    private void start(){
        Mixer.SetFloat("Volume",Mathf.Log10(PlayerPrefs.GetFloat("Volume",1)*20));
    }
    public void OnChangeSlider(float Value){
        ValueText.SetText($"{Value.ToString("N4")}");
        switch(MixMode){
            case AudioMixMode.LinearAudioSourceVolume:
            AudioSource.volume=Value;
            PlayerPrefs.SetFloat("Volume",Value);
            PlayerPrefs.Save();
            break;
            case AudioMixMode.LinearMixerVolume:
            PlayerPrefs.SetFloat("Volume",(-80 + Value * 80));
            //PlayerPrefs.SetFloat("Volume",Value);
            PlayerPrefs.Save();
            break;
            case AudioMixMode.LogrithmicMixerVolume:
            PlayerPrefs.SetFloat("Volume", Mathf.Log10(Value)*20);
            //PlayerPrefs.SetFloat("Volume",Value);
            PlayerPrefs.Save();
            break;
            
        }

    }
    // Start is called before the first frame update
    public enum AudioMixMode{
        LinearAudioSourceVolume,
        LinearMixerVolume,
        LogrithmicMixerVolume

    }
    
}
