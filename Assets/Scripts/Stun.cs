using UnityEngine;
using System.Collections;

public class Stun : MonoBehaviour {

    private PlayerMovement player;

    [SerializeField]
    private GameObject flag;

    private PickUp dropflag;
	// Use this for initialization
	void Start () {
        player = gameObject.GetComponent<PlayerMovement>();

        dropflag = flag.GetComponent<PickUp>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Weapon")
        {
            player.stunned = true;
            dropflag.DropFlag();
            Invoke("BackToNormal", 3f);
        }
    }

    private void BackToNormal() {
        player.stunned = false;
    }
}
