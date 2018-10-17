using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    private int pointValue = 100;

    public float speed;
    private bool movingRight = true;

	void Start () {
		
	}
	

	void Update () {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player") && Input.GetButtonDown("Attack"))
        {
            ScoreScript.AddPoints(pointValue);
            Destroy(gameObject);
        }

    }
}
