using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public float delay;
    public AudioSource audioSource;
    public int levelId;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        audioSource.Stop();
        WindowManager.instance.OpenEndMenu(levelId);
        SceneController.Instance.OpenMainMenu(delay);

    }
}
