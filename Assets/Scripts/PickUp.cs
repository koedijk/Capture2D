using UnityEngine;
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

    // Use this for initialization
    void Awake ()
    {
        FlagColl = GetComponent<BoxCollider2D>();
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {        
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
            DropFlag();
            transform.position = new Vector2(Player_1.transform.position.x, Player_1.transform.position.y + 1f);
            Player1Hold += Time.deltaTime;            
            return;
        }
        else if (Player2)
        {
            DropFlag();
            transform.position = new Vector2(Player_2.transform.position.x, Player_2.transform.position.y + 1f);
            Player2Hold += Time.deltaTime;            
        }
    }

    void DropFlag()
    {        
        if (Input.GetKeyDown(KeyCode.L))
        {
            Player1 = false;
            Player2 = false;
            rigid.gravityScale = 1;
            Physics2D.IgnoreLayerCollision(0, 9, true);
            FlagColl.enabled = true;
            StartCoroutine(wait());                     
        }
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
