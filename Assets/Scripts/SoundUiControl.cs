using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class SoundUiControl : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer effectMixer;
    public Slider musicSlider;
    public Slider effectSlider;
    public  GameObject soundUi;
    void Start()
    {
        musicSlider.onValueChanged.AddListener(MusicVolumeChanged);
        effectSlider.onValueChanged.AddListener(EffectVolumeChanged);
        SoundInit();

    }
    void SoundInit()
    {

        musicMixer.GetFloat("Value", out float musicMixerValue);
        musicSlider.value = musicMixerValue;
        effectMixer.GetFloat("Value", out float effectMixerValue);
        effectSlider.value = effectMixerValue;

        MusicVolumeChanged(musicSlider.value);
        EffectVolumeChanged(effectSlider.value);
    }
    public void MusicVolumeChanged(float value)
    {
        musicMixer.SetFloat("Value", value);
        
    }
    public void EffectVolumeChanged(float value)
    {
        effectMixer.SetFloat("Value", value);
    }
    public void BackGame()
    {
        soundUi.SetActive(false);
    }
}
