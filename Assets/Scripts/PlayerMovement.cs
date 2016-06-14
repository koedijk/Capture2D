using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]
//[RequireComponent(typeof(Collider2D))]
public class PlayerMovement : MonoBehaviour {

    private float MoveX;
    public float movex
    {
        get
        {
            return MoveX;
        }
    }

    [SerializeField]
    private float Speed = 5f;
    [SerializeField]
    private float JumpSpeed = 300f;
    [SerializeField]
    private bool Jumping;
    public bool jumping
    {
        get { return Jumping; }
    }
    private Rigidbody2D rigid;
    public Rigidbody2D rigid1
    {
        get{ return rigid;}
    }
    private string PlayerName;
    private string key;
    private SpriteRenderer sprite;
    public float newSpeed { get { return Speed; } set { Speed = value; } }

    public bool stunned = false;
    // Use this for initialization
    void Awake () {

        //Get objectname for choosing which keys you use base on Player 1 or 2.
        PlayerName = gameObject.name;
        if (PlayerName == "Player1")
        {
            key = "w";
        }
        else
        {
            key = "up";
        }
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //Walking around
        MoveX = Input.GetAxisRaw(PlayerName);
        Move();               
        Jump();
	}

    void Move()
    {
        if (!Jumping & !stunned)
        {
            Vector2 move = new Vector2(MoveX * Speed, rigid.velocity.y);
            rigid.velocity = move;
        }
        else if (Jumping & !stunned)
        {
            Vector2 move = new Vector2(MoveX * Speed / 2, rigid.velocity.y);
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
