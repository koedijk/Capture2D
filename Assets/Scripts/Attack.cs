using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    private Animator anim;
    private Animation anim2;
    private PlayerMovement player;
    [SerializeField]
    private string PlayerName;
    [SerializeField]
    private string AttackKey;
    public bool PlayerAttack = false;
	// Use this for initialization
  
	void Awake ()
    {
        PlayerName = gameObject.name;
        if (PlayerName == "Player1")
        {
            AttackKey = "v";
        }
        else if(PlayerName == "Player2")
        {
            AttackKey = ".";
        }
        player = GameObject.Find(PlayerName).GetComponent<PlayerMovement>(); 
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(AttackKey) && player.jumping == false && PlayerAttack == false)
        {
            anim.SetTrigger("Attack");
            PlayerAttack = true;
            StartCoroutine(wait());
        }
	}

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.2f);
        PlayerAttack = false;
    }
}
