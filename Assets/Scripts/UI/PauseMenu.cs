using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : AbstractMenu
{
    public Transform respawnPoint;
    public Transform player;
    public AudioSource respawnSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
     //   if (Gamepad.current == null) return;
        if (/*Gamepad.current.startButton.IsPressed()||*/Input.GetKeyDown(KeyCode.Escape))
        {
            if (!inMenu)
            {
                Time.timeScale = 0f;
                currentUI.SetActive(true);
                inMenu = true;
            }
            else
            {
                inMenu = false;
                Time.timeScale = 0f;
                currentUI.SetActive(true);

            }
        }
    }

    public void Resume()
    {
        GoToParent();
    }

    public void Respawn() 
    {
        player.position = respawnPoint.position;
        respawnSound.Play();
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
        SceneManager.LoadScene("MainMenu");
    }


}
