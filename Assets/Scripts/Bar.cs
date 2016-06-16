using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour {
    [SerializeField]
    private PickUp time;
    [SerializeField]
    private GameObject BarPlayer1;
    [SerializeField]
    private GameObject BarPlayer2;
    [SerializeField]
    private float currentTimePlayer1 = 0f;
    [SerializeField]
    private float currentTimePlayer2 = 0f;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        currentTimePlayer1 = time.score_1/1500;
        currentTimePlayer2 = time.score_2/1500;
	}
    public void SetBarPlayer1()
    {
        //currentTimePlayer1 = currentTimePlayer1 / maxTime;
        BarPlayer1.transform.localScale = new Vector2(Mathf.Clamp(currentTimePlayer1, 0f, 1f), BarPlayer1.transform.localScale.y);
    }
    public void SetBarPlayer2()
    {
        //currentTimePlayer2 = currentTimePlayer2 / maxTime;
        BarPlayer2.transform.localScale = new Vector2(Mathf.Clamp(currentTimePlayer2, 0f, 1f), BarPlayer2.transform.localScale.y);
    }
}
