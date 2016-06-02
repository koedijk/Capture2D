using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
    private Animator anim;
	// Use this for initialization
	void Awake ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetTrigger("Attack");
        }
	}
}
