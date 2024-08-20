using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager
{
    static WindowManager _instance;

    public static WindowManager instance
    {
        get 
        {
            if (_instance == null)
            {
                _instance = new WindowManager();
                _instance.windows = Storage.instance.Windows;
            }
                
            return _instance;
        }
    }

    WindowsCFG windows;

    public void OpenFailMenu()
    {
        GameObject.Instantiate(windows.failWindow);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void OpenEndMenu(int levelId)
    {    
        GameObject end = GameObject.Instantiate(windows.endMenu);
        Sprite sprite = Storage.instance.EndImg.GetById(levelId);
        end.GetComponent<EndWindowScript>().ChangeImage(sprite);
    }
}
