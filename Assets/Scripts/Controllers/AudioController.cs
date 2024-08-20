using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource source;
    void Start()
    {   
        source = GetComponent<AudioSource>();
        StartCoroutine(Play(Storage.instance.Audio.RandomMenuClip()));
    }

    IEnumerator Play(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
        yield return new WaitForSeconds(clip.length);

        StartCoroutine(Play(Storage.instance.Audio.RandomMenuClip()));
    }

}
