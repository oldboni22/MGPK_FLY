using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingWheel : MonoBehaviour
{
    [SerializeField] private Image _image;
    private void Start()
    {
        LoadingAnimation();
    }
    void LoadingAnimation()
    {
        Color col = new Color(Random.Range(0,1f),Random.Range(0,1f),Random.Range(0,1f));
        col.a = 1;
        _image.DOColor(col, .35f).OnComplete(LoadingAnimation);
    }
    public void Stop()
    {
        _image.DOKill();
        Destroy(gameObject);
    }
}
