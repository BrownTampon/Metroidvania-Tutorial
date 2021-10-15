using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //necassary for animations and physics
    private Animator myanimator;
    private Rigidbody2D rb2D;

    //variables to play with
    public float speed = 2.0f;
    public float horizMovement; //=1 or -1 or 0



    // Start is called before the first frame update
    private void Start()
    {
        //define the gameobjects found on the player
        rb2D = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();

    }

    // handles input for physics
    private void Update()
    {
        //check the direction given by player
        horizMovement = Input.GetAxisRaw("Horizontal");
    }

    //handles running the physics
    private void FixedUpdate()
    {
        //move the character left and right
        rb2D.velocity = new Vector2(horizMovement * speed, rb2D.velocity.y);

    }
}
