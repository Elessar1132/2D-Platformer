using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    GameObject player;
    CharacterController Controller;
    Rigidbody2D PlayerRB2D;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        Controller = player.GetComponent<CharacterController>();
        PlayerRB2D = player.GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame

    public float speed = 10.0f;
    public float jumpSpeed = 5.0f;
    private Vector2 Movement = Vector2.zero;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        Movement.x = Input.GetAxis("Horizontal");

        PlayerRB2D.velocity = new Vector2(Movement.x * speed, PlayerRB2D.velocity.y);
        
        if(Input.GetButton("Jump") && grounded)
        {
            PlayerRB2D.AddForce(new Vector2(0, jumpSpeed));
            //PlayerRB2D.velocity = new Vector2(player.transform.position.x, jumpSpeed);
            grounded = false;
        }
    }
}
