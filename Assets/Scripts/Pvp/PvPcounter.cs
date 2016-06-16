using UnityEngine;
using System.Collections;

public class PvPcounter : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
    public void SetBarPlayer1()
    {
        //currentTimePlayer1 = currentTimePlayer1 / maxTime;
        //Bar_pvp_Player1.transform.localScale = new Vector2(Mathf.Clamp(currentLivesPlayer1, 0f, 1f), Bar_pvp_Player1.transform.localScale.y);
    }
    public void SetBarPlayer2()
    {
        //currentTimePlayer2 = currentTimePlayer2 / maxTime;
        //Bar_pvp_Player2.transform.localScale = new Vector2(Mathf.Clamp(currentLivesPlayer2, 0f, 1f), Bar_pvp_Player2.transform.localScale.y);
    }
}
