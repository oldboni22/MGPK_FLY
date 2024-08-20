using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControll : MonoBehaviour
{
    AudioSource source;

    public int levelId;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        Play(Storage.instance.Audio.GetByLevelId(levelId));
    }

    public void Death() => Play(Storage.instance.Audio.Death());

    void Play(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }

}
