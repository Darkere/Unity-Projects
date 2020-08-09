using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovementSpeed;
    private Rigidbody2D playerBody;
    private Vector2 PlayerMovement;
    private Animator animator;
    private bool moving;


    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement = Vector2.zero;
        PlayerMovement.x = Input.GetAxisRaw("Horizontal");
        PlayerMovement.y = Input.GetAxisRaw("Vertical");
        
        if (PlayerMovement != Vector2.zero)
        {
            moving = true;
        }
        else
        { 
            moving = false;
        }
        UpdateAnimation();


    }
    void UpdateAnimation() 
    {
        if (moving)
        {
            animator.SetFloat("MoveX", PlayerMovement.x);
            animator.SetFloat("MoveY", PlayerMovement.y);
        }
        animator.SetBool("moving", moving);
        
    }
    void FixedUpdate()
    {
        MoveCharacter(PlayerMovement);
    }

    void MoveCharacter(Vector2 dir)
    {
        dir.Normalize();
        playerBody.MovePosition(playerBody.position + dir * MovementSpeed);
    }
}
