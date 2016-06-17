using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
    private PlayerMovement player;
    private PlayerAnimations anim;

    private Respawn respawn_Point;

    public float deaths;
	// Use this for initialization
	void Start () {
        deaths = 0;
        player = gameObject.GetComponent<PlayerMovement>();
        anim = gameObject.GetComponent<PlayerAnimations>();
        respawn_Point = GameObject.Find("RespawnPoint").GetComponent<Respawn>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Weapon")
        {
            dead();
            anim.Death();
            Time.timeScale = 0.001f;
        }
    }

    private void dead() 
    {
        Debug.Log("play anymations");
        deaths++;
        StartCoroutine(respawn());     
    }

    IEnumerator respawn()
    {
        yield return new WaitForSeconds(0.003f);
        Time.timeScale = 1f;
        anim.PlayerDeath = false;
        respawn_Point.BackToPoint();
    }
}

