using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    GameObject player;
    Rigidbody2D PlayerRB2D;
    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        PlayerRB2D = player.GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame

    float speed = 5.0f;
    float jumpSpeed = 5.0f;
    private Vector2 Movement = Vector2.zero;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    private void Update()
    {
        if (grounded && Input.GetButton("Jump"))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        AxisMove(Input.GetAxis("Horizontal"));
    }

    void AxisMove(float axis)
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        Movement.x = axis;

        if (PlayerRB2D)
        {
            PlayerRB2D.velocity = new Vector2(Movement.x * speed, PlayerRB2D.velocity.y);
        }
    }

    void Jump()
    {
        if (!PlayerRB2D)
        {
            PlayerRB2D = player.GetComponent<Rigidbody2D>();
            if (PlayerRB2D)
            {
                PlayerRB2D.velocity = new Vector2(PlayerRB2D.velocity.x, jumpSpeed);

                grounded = false;
            }
            else
            {
                Debug.LogError("Character does not have a rigidbody2D");
            }
        }
        else
        {
            PlayerRB2D.velocity = new Vector2(PlayerRB2D.velocity.x, jumpSpeed);

            grounded = false;
        }
        
    }
}
