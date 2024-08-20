
using UnityEngine;
using UnityEngine.UI;

public class SetProgressBarSkin : MonoBehaviour
{
    void Awake()
    {
        if (PlayerPrefs.GetInt("SkinInd") != 0)
        {
            GetComponent<Image>().sprite = Storage.instance.Skin.sprites[PlayerPrefs.GetInt("SkinInd")];
        }

        Destroy(this);

    }
}
