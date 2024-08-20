using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinButton : MonoBehaviour
{
    public int index;
    SkinsController skinController;

    private void Start()
    {
        skinController = GetComponentInParent<SkinsController>();
    }


    public void Set() => skinController.SetSkin(index);
    
}
