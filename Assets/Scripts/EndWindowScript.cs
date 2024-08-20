
using UnityEngine;
using UnityEngine.UI;

public class EndWindowScript : MonoBehaviour
{
    [SerializeField]Image image;
    [SerializeField] AudioSource audioSource;

    private void Start()
    {
        audioSource.Play();
    }
    public void ChangeImage(Sprite sprite)
    {
        image.sprite = sprite;
    }
}
