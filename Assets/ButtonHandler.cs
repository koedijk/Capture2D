using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ButtonHandler : MonoBehaviour {
    public GameObject[] obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
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
}
