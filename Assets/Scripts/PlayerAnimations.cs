using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {

    private Animator anim1;
    private Animator anim2;
    private float SpeedPlayer1;
    private float SpeedPlayer2;
    private int PlayerIndex = 0;
	// Use this for initialization
	void Awake ()
    {        
        if (gameObject.name == "Player1")
        {
            PlayerIndex = 0;
            anim1 = GameObject.Find("Player1").GetComponent<Animator>();
        }
        else if(gameObject.name == "Player2")
        {
            PlayerIndex = 1;
            anim2 = GameObject.Find("Player2").GetComponent<Animator>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerIndex == 0)
        {
            SpeedPlayer1 = GameObject.Find("Player1").GetComponent<PlayerMovement>().movex;
            anim1.SetFloat("Player1Speed", SpeedPlayer1);
        }
        else if (PlayerIndex == 1)
        {
            SpeedPlayer2 = GameObject.Find("Player2").GetComponent<PlayerMovement>().movex;
            anim2.SetFloat("Player2Speed", SpeedPlayer2);
        }
	}
}
