using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer _mixer;

    public void SetLevel_BGM (float sliderValue)
    {
        _mixer.SetFloat("BGM", Mathf.Log10(sliderValue) * 20);
    }

    public void SetLevel_GameSound(float sliderValue)
    {
        _mixer.SetFloat("GameSound", Mathf.Log10(sliderValue) * 20);
    }
}
