using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSoundStart : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Volume");
        Destroy(this);
    }
}
