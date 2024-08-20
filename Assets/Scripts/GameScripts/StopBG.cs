using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBG : MonoBehaviour
{
    public BackGroundController controller;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.vel = 0;
    }
}
