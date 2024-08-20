using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Storage")]
public class Storage : ScriptableObject
{
    static Storage _instance;

    public static Storage instance 
    {
        get
        {
            if (_instance == null)
                _instance = Resources.Load<Storage>("Storage");

            return _instance;
        }
    }

    public SkinCFG Skin;
    public WindowsCFG Windows;
    public PlayerCFGS PlayerConfigs; 
    public AudioCFG Audio;
    public EndImgCFG EndImg;
}
