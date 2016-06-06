using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    private Animator anim;
    private Animation anim2;
    private PlayerMovement player;
    private string PlayerName;
    public bool PlayerAttack = false;
	// Use this for initialization
  
	void Awake ()
    {
        PlayerName = gameObject.name;
        player = GameObject.Find(PlayerName).GetComponent<PlayerMovement>(); 
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.V) && player.jumping == false)
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
