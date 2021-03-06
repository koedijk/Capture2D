﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonHandler : MonoBehaviour {
    public GameObject[] obj;
    [SerializeField]
    private SoundsValues soundsVolumes;
    private int GameModeInt = 1;
    private bool Sound = true;
    private bool tutorial = true;
    private bool ModeCTF = true;
	// Use this for initialization
	void Awake () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void StartGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("GameMode"));
    }
    public void Options()
    {
        obj[0].SetActive(false);
        obj[1].SetActive(true);
        obj[9].SetActive(false);
        obj[10].SetActive(true);  
    }
    public void BackToMenu()
    {
        obj[0].SetActive(true);
        obj[1].SetActive(false);
        obj[9].SetActive(true);
        obj[10].SetActive(false);
    }
    public void SetSound()
    {
        if (Sound == true)
        {
            PlayerPrefs.SetInt("Sound", 0);
            soundsVolumes.SetSoundVolume();
            obj[3].SetActive(false);
            obj[4].SetActive(true);
            Sound = false;
        }
        else if (Sound == false)
        {
            PlayerPrefs.SetInt("Sound", 1);
            soundsVolumes.SetSoundVolume();
            obj[3].SetActive(true);
            obj[4].SetActive(false);
            Sound = true;
        }
    }
    public void Tutorial()
    {
        if (tutorial == true)
        {
            PlayerPrefs.SetInt("Tutorial", 0);
            obj[5].SetActive(false);
            obj[6].SetActive(true);
            tutorial = false;
        }
        else if (tutorial == false)
        {
            PlayerPrefs.SetInt("Tutorial", 1);
            obj[5].SetActive(true);
            obj[6].SetActive(false);
            tutorial = true;
        }
    }
    public void GameMode()
    {
        if (ModeCTF == true)
        {
            PlayerPrefs.SetInt("GameMode", 2);
            obj[7].SetActive(false);
            obj[8].SetActive(true);
            ModeCTF = false;
        }
        else if (ModeCTF == false)
        {
            PlayerPrefs.SetInt("GameMode", 1);
            obj[7].SetActive(true);
            obj[8].SetActive(false);
            ModeCTF = true;
        }
    }
}
