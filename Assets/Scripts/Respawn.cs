using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    private GameObject player1;
    private GameObject player2;

    private Vector2 player1_point;
    private Vector2 player2_point;
	// Use this for initialization
	void Start () {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");

        player1_point = player1.transform.position;
        player2_point = player2.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //makes the players go back after a kills
    public void BackToPoint() 
    {
        player1.transform.position = player1_point;
        player2.transform.position = player2_point;
    }
}
