﻿using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {

    private Animator anim;
    private PlayerMovement move;
    private Attack attack;
    public float SpeedPlayer;
    private int Switch;
    public bool Left;
    public bool Right;
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
        if (move.stunned == true)
        {
            anim.Play("Stun");
            return;
        }
        SpeedPlayer = GameObject.Find(Playername).GetComponent<PlayerMovement>().movex;
        if (SpeedPlayer > 0.1)
        {
            Left = false;
            Right = true;
        }

        else if (SpeedPlayer < -0.1)
        {
            Right = false;
            Left = true;            
        }
        else if (SpeedPlayer == 0f && attack.PlayerAttack == false)
        {
            anim.Play("Idle");
        }
        if (move.jumping == false && attack.PlayerAttack == false)
        {            
            if (Right)
            {
                anim.Play("Run Right");
                return;
            }
            else if (Left)
            {
                anim.Play("Run Left");
                return;
            }
        }
        
        if (move.jumping == true && Right == true)
        {
            anim.Play("Jump Right Up");
            return;
        }
        else if (move.jumping == true && Left == true)
        {
            anim.Play("Jump Left Up");
            return;
        }
    }
}
