using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour {

    Rigidbody2D myrigidbody;
    Animator anim;
    public Transform animatorTransform;

    void Start ()
    {
        anim = GetComponentInChildren<Animator>(); 
        myrigidbody = GetComponent<Rigidbody2D>();
    }
	

	void FixedUpdate () {

        bool attack = Input.GetButtonDown("Attack");

        if(attack == true)
        {
            anim.SetTrigger("Attacking");
        }
		
	}
}
