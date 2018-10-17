using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

    SpriteRenderer spriteRenderer;

	void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    public void change(Sprite differentSprite)
    {
        spriteRenderer.sprite = differentSprite; 
    }
}
