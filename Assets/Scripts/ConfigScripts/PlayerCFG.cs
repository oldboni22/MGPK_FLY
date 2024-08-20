using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Player")]
public class PlayerCFG : ScriptableObject
{
    public int levelId;

    [Header("Gameplay")]
    public float Vel;
    public float JumpForce;

    [Header("ForceControll")]
    public float jumpStackSanction;
    public float jumpVelReduction;
    public float stackRessetTime;
    public float randomFactor;

}
