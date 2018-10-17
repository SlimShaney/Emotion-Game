using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    private int pointValue = 50;

    void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {        
            if (col.gameObject.tag.Equals("Player"))
            {
            ScoreScript.AddPoints(pointValue);
            Destroy(gameObject);
            }
            
    }
}
