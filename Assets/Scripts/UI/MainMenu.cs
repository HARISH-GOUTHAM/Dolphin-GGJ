using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : AbstractMenu
{
   
    public void Play()
    {
        SceneManager.LoadScene("MainLevel");

    }

    public void Settings()
    {
        GoToChild(1);
    }

    public void Controls()
    {
        GoToChild(0);

    }
    public void Credits()
    {
        GoToChild(2);

    }

    public void Quit()
    {
        Application.Quit();
    }


}
