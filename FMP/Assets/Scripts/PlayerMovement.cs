using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Animator PlayerAnimator;

    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float VerticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    void Start()
    {
        PlayerAnimator = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerAnimator.SetBool("isMoving", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            PlayerAnimator.SetBool("isMoving", false);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerAnimator.SetBool("isMoving", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            PlayerAnimator.SetBool("isMoving", false);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerAnimator.SetBool("isMoving", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            PlayerAnimator.SetBool("isMoving", false);
        }


        if(Input.GetKeyDown(KeyCode.D))
        {
            PlayerAnimator.SetBool("isMoving", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            PlayerAnimator.SetBool("isMoving", false);
        }


        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();

        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * VerticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }
}
