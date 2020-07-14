﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    

    bool GamePaused;


    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }

    public GameObject PauseScreen;
    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
    public void ReplayPlayGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void Gomainmenu()
    {
        SceneManager.LoadScene("menu");

    }
    public void PauseGame()
    {
        GamePaused = true;
        PauseScreen.SetActive(true);
       
    }

    public void ResumeGame()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        
    }
}