using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Audio")]
public class AudioCFG : ScriptableObject
{
    [SerializeField] AudioClip[] clips;
    [SerializeField] AudioClip[] menuClips;
    [SerializeField] AudioClip deathSound;
    

    public AudioClip GetByLevelId(int Id) => clips[Id - 1];
    public AudioClip Death() => deathSound;
    public AudioClip RandomMenuClip() => menuClips[Random.Range(0,menuClips.Length - 1)];

}
