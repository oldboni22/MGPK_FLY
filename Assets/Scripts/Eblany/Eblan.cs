using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eblan : MonoBehaviour
{
    int id;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] float x;
    [SerializeField] float y;


    // Start is called before the first frame update
    void Start()
    {
        OneMove();
        SetSkin();
    }

    // Update is called once per frame
    public void SetId(int id)
    {
        this.id = id;
    }

    public int Id() => id;
    void OneMove()
    {
        float newX, newY, duration;

        newX = Random.Range(-x, x);
        newY = Random.Range(-y, y);
        duration = Random.Range(1.1f, 2.2f);

        Vector3 newPos = new Vector3(newX, newY, 0);

        var sequence = DOTween.Sequence();
        sequence.intId = id;

        sequence.Append(transform.DOMove(newPos, duration));
        sequence.Join((transform.DORotate(new Vector3(Random.Range(0, 360f), Random.Range(0, 360f), Random.Range(0, 360f)), duration)));

        sequence.OnComplete(OneMove);
    }

    private void OnDestroy()
    {
        DOTween.Kill(id);
    }
    void SetSkin()
    {
        spriteRenderer.sprite = Storage.instance.Skin.GetRandom();
    }
}
