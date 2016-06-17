using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    private TimerBar time;

    private Death player_1;
    private Death player_2;

    [SerializeField]
    private float kills_1;
    [SerializeField]
    private float kills_2;

    private PickUp score;


    [SerializeField]
    private GameObject player_1_win;
    [SerializeField]
    private GameObject player_2_win;

	// Use this for initialization
	void Start () {
        time = GameObject.Find("EventSystem").GetComponent<TimerBar>();
        player_1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Death>();
        player_2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Death>();

        score = GameObject.Find("Flag").GetComponent<PickUp>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("GameMode") == 1)
        {
            Flag_Win();
        }
        else if (PlayerPrefs.GetInt("GameMode") == 2)
        {
            PvP_Win();
        }

        kills_1 = player_2.deaths;
        kills_2 = player_1.deaths;
	}

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(0.003f);
        SceneManager.LoadScene("MainMenu");
    }

    // win condition for the pvp mode
    void PvP_Win()
    {
        if (time.timeLeft < 0)
        {
            if (kills_1 > kills_2)
            {
                Player_1_WinScreen();
            }
            else {
                Player_2_WinScreen();
            }
        }

        else if (kills_1 == 10)
        {
            Player_1_WinScreen();
        }

        else if (kills_2 == 10)
        {
            Player_2_WinScreen();
        }
    }

    // win condition for the flag mode
    private void Flag_Win()
    {
        if (score.score_1 == 1500)
        {
            Player_1_WinScreen();
        }
        if (score.score_2 == 1500)
        {
            Player_2_WinScreen();
        }
    }

    private void Player_1_WinScreen() {
        Time.timeScale = 0.001f;
        player_1_win.SetActive(true);
        StartCoroutine(BackToMenu());
    }

    private void Player_2_WinScreen()
    {
        Time.timeScale = 0.001f;
        player_2_win.SetActive(true);
        StartCoroutine(BackToMenu());
    }
}
