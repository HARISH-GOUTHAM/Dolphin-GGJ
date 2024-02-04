using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : AbstractMenu
{
    public Transform RespawnPoint;
    public Transform player;
    public AudioSource respawnSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        RespawnPoint = GameObject.FindGameObjectWithTag("RespawnPoint").GetComponent<Transform>();
    }

    private void Update()
    {
        if (Gamepad.current == null)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!inMenu)
                {
                    Time.timeScale = 0f;
                    currentUI.SetActive(true);
                    inMenu = true;
                }

            }
        }
        else
        {
            if (Gamepad.current.startButton.IsPressed() || Input.GetKeyDown(KeyCode.Escape))
            {
                if (!inMenu)
                {
                    Time.timeScale = 0f;
                    currentUI.SetActive(true);
                    inMenu = true;
                }

            }
        }
        
        if(inMenu)
            Cursor.lockState = CursorLockMode.None;
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void Resume()
    {
        inMenu = false;
        GoToParent();
    }

    public void Respawn() 
    {
        player.position = RespawnPoint.position;
        respawnSound.Play();
        inMenu = false;
        Time.timeScale = 1f;
        currentUI.SetActive(false);


    }
    public void Controls()
    {
        GoToChild(0);
    }

    public void Setting()
    {
        GoToChild(1);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenuFinal");
    }


}
