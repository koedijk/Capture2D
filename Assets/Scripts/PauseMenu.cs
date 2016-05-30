using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PauseMenu : MonoBehaviour {
    [SerializeField]
    private List<string> pause = new List<string>();
    [SerializeField]
    private GameObject[] obj;
    private bool PauseActive = false;

    void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        obj = GameObject.FindGameObjectsWithTag("PauseMenu");
        for(int i = 0; i < obj.Length; i++)
        {
            obj[i].SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !PauseActive)
        {
            obj[0].SetActive(true);
            PauseActive = true;
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && PauseActive)
        {
            obj[0].SetActive(false);
            PauseActive = false;
            Time.timeScale = 1;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void StopPause()
    {
        obj[0].SetActive(false);
        PauseActive = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}
