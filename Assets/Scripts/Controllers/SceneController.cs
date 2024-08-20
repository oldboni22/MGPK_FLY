using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    delegate void meth();
    bool ManualReturn = true;
    string _currentSceneName;

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


    public void OpenScene(string sceneName)
    {
        _currentSceneName = sceneName;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    
    public void OpenMainMenu() => SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    public void OpenMainMenu(float delay) => StartCoroutine(Delay(delay,OpenMainMenu));
    public void ReOpenScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    public void ReOpenScene(float delay) => StartCoroutine(Delay(delay,ReOpenScene));
    public string currentSceneName => _currentSceneName;


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

    IEnumerator Delay(float delay, meth method)
    {
        ManualReturn = false;

        yield return new WaitForSeconds(delay);

        ManualReturn = true;
        method();
    }

}
