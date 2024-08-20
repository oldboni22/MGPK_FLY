using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SceneOpener : MonoBehaviour
{
    [SerializeField] private AssetReference _sceneRef;

    public void OpenScene() => SceneController.Instance.OpenScene(_sceneRef);

    public void ReOpenScene() => SceneController.Instance.ReOpenScene();
}
