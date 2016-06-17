using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
    private PlayerMovement player;

    private Respawn respawn_Point;

    public float deaths;
	// Use this for initialization
	void Start () {
        deaths = 0;
        player = gameObject.GetComponent<PlayerMovement>();
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
        yield return new WaitForSeconds(1);
        respawn_Point.BackToPoint();
    }
}

