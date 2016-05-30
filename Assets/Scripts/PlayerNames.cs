using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerNames : MonoBehaviour {
    [SerializeField]
    private List<GameObject> Players = new List<GameObject>();
    private string Playername = "Player1";
    private Vector3 offset = new Vector2(0.05f, 0.6f);
    [SerializeField]
    private GameObject[] text;
     
	// Use this for initialization
	void Start ()
    {
        Transform[] AmountOfPlayers = this.GetComponentsInChildren<Transform>();
        for (int i = 1; i < AmountOfPlayers.Length; i++)
        {
            Players.Add(AmountOfPlayers[i].gameObject);
        }

        
	}
	
	// Update is called once per frame
	void Update () {
        text[0].transform.position = (Players[0].transform.position + offset);
        text[1].transform.position = (Players[1].transform.position + offset);
	}

    /*void OnGUI()
    {
        for (int i = 0; i < Players.Count; i++)
        {
            Vector3 offset = new Vector2(0.35f, 0.5f); // height above the target position
            Vector2 point = Camera.main.WorldToScreenPoint(Players[i].transform.position + offset);
            point.y = Screen.height - point.y;
            GUI.Label(new Rect(point.x - 35, point.y - 20, 200, 20), (string)Players[i].name);
        }

    }*/
}
