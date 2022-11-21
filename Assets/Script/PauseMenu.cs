using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;

    void Start()
    {
        UnPaused();
    }

    public void Paused() //when paused is triggered
    {
        pauseMenuCanvas.SetActive(true);
        //stop our time
        Time.timeScale = 0;
    }
    public void UnPaused() //when unpaused is triggered
    {
        //unpause our game if attached to a button...doesn't matter if it's an ESC toggle
        //isPaused = false;
        pauseMenuCanvas.SetActive(false);
        //start time
        Time.timeScale = 1;
    }
    private void Update()
    {
        //GetKeyDown    On Press
        //GetKey        While Held
        //GetKeyUp      On Release
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuCanvas.SetActive(true);
            Paused();
        }
    }
}
