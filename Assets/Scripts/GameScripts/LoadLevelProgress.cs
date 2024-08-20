using UnityEngine;
using TMPro;

public class LoadLevelProgress : MonoBehaviour
{
    public string sceneName;
    void Start()
    {
        GetComponent<TMP_Text>().text += $" | {Mathf.Round(PlayerPrefs.GetFloat(sceneName) * 100)} %";
        Debug.Log($"{PlayerPrefs.GetFloat(sceneName)}");
    }

}
