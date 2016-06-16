using UnityEngine;
using System.Collections;

public class PVP_Bar : MonoBehaviour {
    [SerializeField]
    private GameObject BarPlayer1;
    [SerializeField]
    private GameObject BarPlayer2;
    [SerializeField]
    private float maxTime = 30f;
    [SerializeField]
    private float currentKillsPlayer1 = 0f;
    [SerializeField]
    private float currentKillsPlayer2 = 0f;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        //currentKillsPlayer1;
        //currentKillsPlayer2;
    }
    public void SetBarPlayer1()
    {
        //currentTimePlayer1 = currentTimePlayer1 / maxTime;
        BarPlayer1.transform.localScale = new Vector2(Mathf.Clamp(currentKillsPlayer1, 0f, 1f), BarPlayer1.transform.localScale.y);
    }
    public void SetBarPlayer2()
    {
        //currentTimePlayer2 = currentTimePlayer2 / maxTime;
        BarPlayer2.transform.localScale = new Vector2(Mathf.Clamp(currentKillsPlayer2, 0f, 1f), BarPlayer2.transform.localScale.y);
    }
}
