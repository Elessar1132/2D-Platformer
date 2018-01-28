using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    GameObject gameObj;
    Rigidbody2D RB2D;
    // Use this for initialization
    void Start ()
    {
        
        gameObj = gameObject;
        RB2D = gameObj.GetComponent<Rigidbody2D>();
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

        if (RB2D)
        {
            RB2D.velocity = new Vector2(Movement.x * speed, RB2D.velocity.y);
        }
    }

    void Jump()
    {
        if (!RB2D)
        {
            RB2D = gameObj.GetComponent<Rigidbody2D>();
            if (RB2D)
            {
                RB2D.velocity = new Vector2(RB2D.velocity.x, jumpSpeed);

                grounded = false;
            }
            else
            {
                Debug.LogError("Character does not have a rigidbody2D");
            }
        }
        else
        {
            RB2D.velocity = new Vector2(RB2D.velocity.x, jumpSpeed);

            grounded = false;
        }
        
    }
}
