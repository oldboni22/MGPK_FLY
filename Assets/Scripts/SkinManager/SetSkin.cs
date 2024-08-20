using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.GetInt("SkinInd") != 0)
        {
            GetComponent<SpriteRenderer>().sprite = Storage.instance.Skin.sprites[PlayerPrefs.GetInt("SkinInd")];
        }

        Destroy(this);

    }

   
}
