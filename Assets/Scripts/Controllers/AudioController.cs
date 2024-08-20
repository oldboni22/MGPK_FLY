using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource source;
    void Start()
    {   
        source = GetComponent<AudioSource>();
        StartCoroutine(Play());
    }


    IEnumerator Play()
    {

        yield return new WaitWhile(() => Storage.instance == null);
        var clip = Storage.instance.Audio.RandomMenuClip();

        source.clip = clip;
        source.Play();
        yield return new WaitForSeconds(clip.length);

        StartCoroutine(Play());
    }

}
