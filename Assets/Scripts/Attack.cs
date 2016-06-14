using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    public GameObject attackColRight;
    public GameObject attackColLeft;
    private Animator anim;
    public PlayerAnimations animations;
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
            AttackKey = "insert";
        }
        player = GameObject.Find(PlayerName).GetComponent<PlayerMovement>();
        anim = GetComponent<Animator>();
        attackColRight.SetActive(false);
        attackColLeft.SetActive(false);

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerAttack == true)
        {
            if (animations.Right == true & player.stunned == false)
            {
                attackColRight.SetActive(true);
                attackColLeft.SetActive(false);
                return;
            }
            else if (animations.Left == true & player.stunned == false)
            {
                attackColLeft.SetActive(true);
                attackColRight.SetActive(false);
                return;
            }
            else if (animations.Right == false && animations.Left == false & player.stunned == false)
            {
                attackColRight.SetActive(true);
            }
            
        }

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
        attackColRight.SetActive(false);
        attackColLeft.SetActive(false);
    }
}
