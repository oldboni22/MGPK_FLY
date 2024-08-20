using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkinsController : MonoBehaviour
{
    Button[] buttons;
    void Start()
    {
        buttons = GetComponentsInChildren<Button>();       
    }

    public void SetSkin(int index)
    {
        PlayerPrefs.SetInt("SkinInd",index);
        PlayerPrefs.Save();
    }

    public void SetDefault()
    {
        PlayerPrefs.SetInt("SkinInd", 0);
        PlayerPrefs.Save();
    }



}
