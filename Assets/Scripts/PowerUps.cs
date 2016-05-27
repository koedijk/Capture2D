using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {

    private PlayerMovement playerStats;

	// Use this for initialization
	void Start () {
        playerStats = new PlayerMovement();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        PlayerMovement pickup = coll.gameObject.GetComponent<PlayerMovement>();

        pickup.newSpeed = 10;
    }
}
