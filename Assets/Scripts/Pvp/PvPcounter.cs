using UnityEngine;
using System.Collections;

public class PvPcounter : MonoBehaviour
{
    private Death player_1;
    private Death player_2;

    //player kills
    [SerializeField]
    private float kills_1;
    [SerializeField]
    private float kills_2;

    //player bars
    [SerializeField]
    private GameObject Bar_pvp_Player1;
    [SerializeField]
    private GameObject Bar_pvp_Player2;

    // Use this for initialization
    void Start()
    {
        player_1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<Death>();
        player_2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<Death>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        kills_1 = player_2.deaths / 20f;
        kills_2 = player_1.deaths / 20f;

        SetBarPlayer1();
        SetBarPlayer2();
    }

    //set kills on the player barrs
    public void SetBarPlayer1()
    {
        Bar_pvp_Player1.transform.localScale = new Vector2(Mathf.Clamp(kills_1, 0f, 1f), Bar_pvp_Player1.transform.localScale.y);
    }
    public void SetBarPlayer2()
    {
        Bar_pvp_Player2.transform.localScale = new Vector2(Mathf.Clamp(kills_2, 0f, 1f), Bar_pvp_Player2.transform.localScale.y);
    }
}
