using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerMovement : MonoBehaviour {

    private float MoveX;
    [SerializeField]
    private float Speed = 5f;
    [SerializeField]
    private float JumpSpeed = 300f;
    [SerializeField]
    private bool Jumping;
    private Rigidbody2D rigid;
    [SerializeField]
    private string PlayerName;
    private string key;
    public float newSpeed { get { return Speed; } set { Speed = value; } }
    // Use this for initialization
    void Awake () {
        //Get objectname for choosing which keys you use base on Player 1 or 2.
        PlayerName = gameObject.name;
        if (PlayerName == "Player1")
        {
            key = "space";
        }
        else
        {
            key = "right ctrl";
        }
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //Walking around
        MoveX = Input.GetAxisRaw(PlayerName);
        if (Input.GetAxisRaw(PlayerName) > 0.1f || Input.GetAxisRaw(PlayerName) < 0.1f)
        {            
            Move();
        }        
        Jump();
	}

    void Move()
    {
        // Can Walk if not Jumping
        if (!Jumping)
        {
            Vector2 move = new Vector2(MoveX * Speed, 0);
            rigid.velocity = move;
        }
        
    }

    void Jump()
    {   
        //Can Jump if not Jumping     
        if (Input.GetKeyDown(key) && !Jumping)
        {            
            rigid.AddForce(Vector2.up * JumpSpeed);
            Jumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            Jumping = false;
        }
    }
}
