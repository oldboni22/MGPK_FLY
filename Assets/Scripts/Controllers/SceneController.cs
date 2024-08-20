using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    bool ManualReturn = true;

    AssetReference _currentScene;
    private string _sceneName;

    private void Awake()
    {
        if (_instance == null)
        {
            DontDestroyOnLoad(gameObject);
            _instance = this;
        }
        else Destroy(gameObject);
        
    }

    static SceneController _instance;
    public static SceneController Instance { get => _instance; }


    public void OpenScene(AssetReference sceneRef)
    {
        Addressables.LoadSceneAsync(sceneRef, LoadSceneMode.Single).Completed += ((x) => 
        {
            _sceneName = SceneManager.GetActiveScene().name;
            Debug.Log(_sceneName);
        }) ;
        _currentScene = sceneRef;
        
    }
    
    public void OpenMainMenu() => SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    public void OpenMainMenu(float delay) => StartCoroutine(Delay(delay,OpenMainMenu));
    public void ReOpenScene() => Addressables.LoadSceneAsync(_currentScene, LoadSceneMode.Single);
    public void ReOpenScene(float delay) => StartCoroutine(Delay(delay,ReOpenScene));
    public string currentSceneName => _sceneName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && ManualReturn)
        {
            if(SceneManager.GetActiveScene().name == "Main Menu")
            {
                Application.Quit();
            }
            else
            {
                StopAllCoroutines();
                OpenMainMenu();
                Cursor.visible = true;
            }
        }
    }

    IEnumerator Delay(float delay, Action action)
    {
        ManualReturn = false;

        yield return new WaitForSeconds(delay);

        ManualReturn = true;
        action();
    }

}
