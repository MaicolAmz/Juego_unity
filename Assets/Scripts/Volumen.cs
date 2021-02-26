﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        checkIsMute();
    }

    public void changeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        checkIsMute();
    }

    // Update is called once per frame
    void checkIsMute()
    {
        if( sliderValue == 0 )
        {
            imagenMute.enabled = false;
        }
        else {
            imagenMute.enabled = true;
        }
    }
}
