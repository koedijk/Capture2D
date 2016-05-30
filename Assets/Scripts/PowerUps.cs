using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {

    private PlayerMovement playerStats;

	// Use this for initialization
	void Start () {
        playerStats = new PlayerMovement();
        playerStats = gameObject.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Power_Up_Speed")
        {
            playerStats.newSpeed = 10f;
            Destroy(coll.gameObject);
            Invoke("ReturnToNormal", 3f);
        }
    }

    void ReturnToNormal()
    {
        playerStats.newSpeed = 5f;
    }
}
