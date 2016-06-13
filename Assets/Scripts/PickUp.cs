﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUp : MonoBehaviour {
    [SerializeField]
    private float Player1Hold;
    [SerializeField]
    private float Player2Hold;
    [SerializeField]
    private bool Player1 = false;
    [SerializeField]
    private GameObject Player_1;
    [SerializeField]
    private bool Player2 = false;
    [SerializeField]
    private GameObject Player_2;
    [SerializeField]
    private BoxCollider2D FlagColl;
    private Rigidbody2D rigid;

    public Scrollbar scoreBarr_1;
    public Scrollbar scoreBarr_2;
    public float score_1 = 0;
    public float score_2 = 0;

    // Use this for initialization
    void Awake ()
    {
        FlagColl = GetComponent<BoxCollider2D>();
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        scoreBarr_1.size = score_1;
        scoreBarr_2.size = score_2;

        if (Player1 || Player2)
        {
            TimeHold();
        }
	}

    void TimeHold()
    {        
        rigid.gravityScale = 0;
        FlagColl.enabled = false;
        if (Player1)
        {
            transform.position = new Vector2(Player_1.transform.position.x, Player_1.transform.position.y + 1f);
            score_1 += 0.001f;
            return;
        }
        else if (Player2)
        {
            transform.position = new Vector2(Player_2.transform.position.x, Player_2.transform.position.y + 1f);
            score_2 += 0.001f;         
        }
    }

    public void DropFlag()
    {        
            Player1 = false;
            Player2 = false;
            rigid.gravityScale = 1;
            Physics2D.IgnoreLayerCollision(0, 9, true);
            FlagColl.enabled = true;
            StartCoroutine(wait());                     
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        Physics2D.IgnoreLayerCollision(0, 9, false);  
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player1")
        {
            Player1 = true;
        }
        else if (coll.gameObject.tag == "Player2")
        {
            Player2 = true;
        }
    }
}
