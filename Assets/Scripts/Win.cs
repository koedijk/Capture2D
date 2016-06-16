using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {


    private PickUp score;


    [SerializeField]
    private GameObject player_1_win;
    [SerializeField]
    private GameObject player_2_win;

	// Use this for initialization
	void Start () {
        score = GameObject.Find("Flag").GetComponent<PickUp>();
        //timer = GameObject.Find("EventSystem").GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
            if (score.score_1 == 1500)
            {
                Time.timeScale = 0.001f;
                player_1_win.SetActive(true);
                StartCoroutine(BackToMenu());  
                
            }
            if (score.score_2 == 1500)
            {
                Time.timeScale = 0.001f;
                player_2_win.SetActive(true);
                StartCoroutine(BackToMenu());  
                
            }
	}

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(0.003f);
        SceneManager.LoadScene("MainMenu");
    }
}
