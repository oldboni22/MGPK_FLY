using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangePlayerCfg : MonoBehaviour
{
    public PlayerCFG newConfig;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Player>().SetConfig(newConfig);
    }

}
