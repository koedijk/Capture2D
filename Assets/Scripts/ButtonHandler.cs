using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonHandler : MonoBehaviour {
    public GameObject[] obj;
    public Text Player1;
    public Text Player2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        PlayerPrefs.SetString("Player1Name", Player1.text);
        PlayerPrefs.SetString("Player2Name", Player2.text);
        SceneManager.LoadScene(1);
    }
    public void Options()
    {
        obj[0].SetActive(false);
        obj[1].SetActive(true);   
    }
    public void BackToMenu()
    {
        obj[0].SetActive(true);
        obj[1].SetActive(false);
    }
    public void ChooseNames()
    {
        obj[0].SetActive(false);
        obj[2].SetActive(true);
    }
    public void HowToPlay()
    {
    
    }
}
