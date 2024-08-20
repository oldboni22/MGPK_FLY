using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Skin")]
public class SkinCFG : ScriptableObject
{
    public Sprite[] sprites;

    public Sprite GetRandom() => sprites[Random.Range(1,sprites.Length-1)];
}
