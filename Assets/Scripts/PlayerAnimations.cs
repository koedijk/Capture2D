using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {

    private Animator anim;
    private PlayerMovement move;
    private Attack attack;
    public float SpeedPlayer;
    private int Switch;
    public bool Left;
    public bool Right;
    public bool PlayerDeath = false;
    private string Playername;
	// Use this for initialization
	void Awake ()
    {        
        Playername = gameObject.name;
        move = GameObject.Find(Playername).GetComponent<PlayerMovement>();
        attack = GameObject.Find(Playername).GetComponent<Attack>();
        if (Playername == "Player1")
        {
            anim = GameObject.Find(Playername).GetComponent<Animator>();
            return;
        }
        else if(Playername == "Player2")
        {
            anim = GameObject.Find(Playername).GetComponent<Animator>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        AnimPlayer(); 
    }

    void AnimPlayer()
    {
        if (PlayerDeath == true)
        {
            return;
        }
        if (move.stunned == true)
        {
            anim.Play("Stun");
            return;
        }
        SpeedPlayer = GameObject.Find(Playername).GetComponent<PlayerMovement>().movex;
        if (SpeedPlayer > 0.5)
        {
            Left = false;
            Right = true;
        }

        else if (SpeedPlayer < -0.5)
        {
            Right = false;
            Left = true;          
        }

        if (move.jumping == false && attack.PlayerAttack == false)
        {            
            if (SpeedPlayer > 0.1f)
            {
                anim.Play("Run Right");
            }
            else if (SpeedPlayer < -0.1f)
            {
                anim.Play("Run Left");
                return;
            }
        }
        if (SpeedPlayer == 0 && attack.PlayerAttack == false && move.jumping == false)
        {
            anim.Play("Idle");
            if (Right == true && Left == false)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (Left == true && Right == false)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (move.jumping == true && Right == true && Left == false)
        {
            anim.Play("Jump Right Up");
        }
        else if (move.jumping == true && Left == true && Right == false)
        {
            anim.Play("Jump Left Up");
        }
    }
    public void Death()
    {
        anim.Play("Death");
        PlayerDeath = true;
    }
}
