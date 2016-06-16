using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
    private PlayerMovement player;

    private Vector2 StartPosition;

    public float deaths;
	// Use this for initialization
	void Start () {
        player = gameObject.GetComponent<PlayerMovement>();
        StartPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Weapon")
        {
            dead();
            Invoke("BackToNormal", 3f);
        }
    }

    private void BackToNormal() {
        player.stunned = false;
    }

    private void dead() 
    {
        Debug.Log("play anymations");
        deaths= +1;
        StartCoroutine(respawn());     
    }

    IEnumerator respawn()
    {
        yield return new WaitForSeconds(1);
        this.transform.position = StartPosition;
    }
}

