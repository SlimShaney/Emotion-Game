using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCScript : MonoBehaviour {

    public bool Moving;
    public bool TurnAround;
    public float moveSpeed;
    public float turnTimer;
    float lastTurnedTime;

    void Start()
    {
        lastTurnedTime = Time.time;
    }

    void FixedUpdate()
    {
        if (Moving == true)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        }


        if (TurnAround == true && (Time.time - lastTurnedTime >= turnTimer))
        {
            moveSpeed = -moveSpeed;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            lastTurnedTime = Time.time;
        }
    }

}

