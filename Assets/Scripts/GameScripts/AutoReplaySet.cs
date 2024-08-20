using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoReplaySet : MonoBehaviour
{
    [SerializeField] Toggle toggle;
    private void Start()
    {
        int intValue = PlayerPrefs.GetInt("AutoReplay");
        toggle.isOn = intValue == 1;
    }
    public void Set(bool value)
    {
        int intValue = value ? 1 : 0;
        PlayerPrefs.SetInt("AutoReplay",intValue);
        Debug.Log(PlayerPrefs.GetInt("AutoReplay"));
        PlayerPrefs.Save();
    }
}
