using UnityEngine;
using System.Collections;

public class Stun : MonoBehaviour {

    private PlayerMovement player;

    [SerializeField]
    private GameObject foot;
	// Use this for initialization
	void Start () {
        player = gameObject.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("ok");
        if (coll.gameObject == foot)
        {
            player.stunned = true;
            Invoke("BackToNormal", 3f);
        }
    }

    private void BackToNormal() {
        player.stunned = false;
    }
}
