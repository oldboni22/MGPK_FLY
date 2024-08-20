using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOpener : MonoBehaviour
{
    public string SceneName;

    public void OpenScene() => SceneController.Instance.OpenScene(SceneName);

    public void ReOpenScene() => SceneController.Instance.ReOpenScene();
}
