using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Respawn : MonoBehaviour
{
    
    public Transform respawnPoint;
    public Transform player;
    public AudioSource respawnSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Gamepad.current.rightStickButton.wasPressedThisFrame)
        {
            player.position = respawnPoint.position;
            respawnSound.Play();
        }
    }
}
