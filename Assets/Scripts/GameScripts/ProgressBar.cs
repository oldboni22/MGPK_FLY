using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] float end;
    [SerializeField] TMP_Text text;
    [SerializeField] Player player;
    [SerializeField] Slider slider;
    float _progress;
    Transform transformPlayera;

    private void Awake()
    {
        player.death.AddListener(OnDeath);
        transformPlayera = player.transform;
    }

    void OnDeath() 
    {
        if(PlayerPrefs.GetFloat(SceneController.Instance.currentSceneName) < _progress)
            PlayerPrefs.SetFloat(SceneController.Instance.currentSceneName, _progress);
        Debug.Log(SceneController.Instance.currentSceneName);

        PlayerPrefs.Save();
    }

    void Update()
    {
        if (player == null)
            return;

        float plaerX = transformPlayera.position.x;

        if (plaerX < 0)
            return;

        _progress = plaerX / end;
        slider.value = _progress;
        text.text = $"{Mathf.Round(_progress * 100)}%";
    }
}
