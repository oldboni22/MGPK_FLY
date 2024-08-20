using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Xml.Serialization;
using System;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public AudioSource audioSource;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
        UpdateValues();
    }

    public void OnValueChange()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
        PlayerPrefs.Save();
        UpdateValues(); 
    }

    void UpdateValues()
    {   
        audioSource.volume = PlayerPrefs.GetFloat("Volume");
        text.text = $"{Math.Round(PlayerPrefs.GetFloat("Volume") * 100)}%";
    }
}
