using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerNames : MonoBehaviour {
    [SerializeField]
    private List<GameObject> Players = new List<GameObject>();
    
    private Vector3 offset = new Vector2(0.05f, 0.8f);
    private int t;
    [SerializeField]
    private Text Player1Name;
    [SerializeField]
    private Text Player2Name;
     
	// Use this for initialization
	void Awake ()
    {
        Players.Add(GameObject.Find("Player1"));
        Players.Add(GameObject.Find("Player2"));
        Player1Name = GameObject.Find("Player1_Text").GetComponent<Text>();
        Debug.Log(Player1Name);
        Player2Name = GameObject.Find("Player2_Text").GetComponent<Text>();
        Debug.Log(Player2Name);
        Player1Name.text = PlayerPrefs.GetString("Player1Name");
        Player2Name.text = PlayerPrefs.GetString("Player2Name");
        if (PlayerPrefs.GetString("Player1Name") == "")
        {
            t = Random.Range(0, 99999);
            Player1Name.text = "" + t;
        }
        if (PlayerPrefs.GetString("Player2Name") == "")
        {
            t = Random.Range(0, 99999);
            Player2Name.text = "" + t;
        }
    }
	
	// Update is called once per frame
	void Update () {
        Player1Name.transform.position = (Players[0].transform.position + offset);
        Player2Name.transform.position = (Players[1].transform.position + offset);

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
