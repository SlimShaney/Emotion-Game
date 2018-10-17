using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public float maxSpeed;
    public float accelerationSpeed;//how fast the Rigidbody will accelerate to maxSpeed
    Rigidbody2D myrigidbody; //sets a variable called myrigidbody of type Rigidbody2D. not written as public so will be stored privately
    Animator anim; //sets a variable called anim of type Animator
    float hSpeed; //this will be used to check for the horizontal velocity of the Rigidbody2D
    float vSpeed;//this will be used to check for the vertical velocity of the Rigidbody2D
    public Transform animatorTransform;


    void Start()
    {
        anim = GetComponentInChildren<Animator>(); //getcomponent Animator and assigns it to anim
        myrigidbody = GetComponent<Rigidbody2D>(); //getcomponent Rigidbody2D and assigns it to myrigidbody
    }



    void FixedUpdate()
    {

        hSpeed = myrigidbody.velocity.x;
        vSpeed = myrigidbody.velocity.y;

        float moveH = Input.GetAxis("Horizontal"); //checks input axis on the horizontal, so A, D or arrow left/right buttons - will also work with a controller
        
        //this following if/else statement tells the Animator if the right or left button has been pressed
        if (moveH > 0)
        {
            animatorTransform.localScale = new Vector3(-1, animatorTransform.localScale.y, animatorTransform.localScale.z);
            transform.Translate(Vector3.right * accelerationSpeed * Time.deltaTime, Space.World);
            
        }
        else if (moveH < 0)
        {
            animatorTransform.localScale = new Vector3(1, animatorTransform.localScale.y, animatorTransform.localScale.z);
            transform.Translate(Vector3.left * accelerationSpeed * Time.deltaTime, Space.World);
        }


        float moveV = Input.GetAxis("Vertical"); //checks input axis on the vertical, so W, S or arrow up/down buttons - will also work with a controller

        //this following if/else statement tells the Animator if the up or down button has been pressed
        if (moveV > 0)
        {
            transform.Translate(Vector3.up * accelerationSpeed * Time.deltaTime, Space.World);
        }
        else if (moveV < 0)
        {
            transform.Translate(Vector3.down * accelerationSpeed * Time.deltaTime, Space.World);
        }

        if (moveH > 0 || moveH < 0 || moveV > 0 || moveV < 0)
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
    }        
}



