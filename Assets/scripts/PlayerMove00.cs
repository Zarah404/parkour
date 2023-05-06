using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove00 : MonoBehaviour
{
    Animator animator;
    public float speed;
    //public Rigidbody rb;

    public float jumpForce = 10f;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator= GetComponent<Animator>();
        //rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float v = Input.GetAxis("Vertical");
        animator.SetFloat("run", v);
        transform.Translate(Vector3.forward * v * speed*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed= 3f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed= 1f;
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("slash");
        }

       /* if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump();
            Debug.Log("jump");
        }
         */ 
    }
/*
     private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
    }

    private void jump()
    {
        velocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
    }

    bool IsGrounded()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, groundCheckDistance, groundLayer))
        {
            // Debug information
            Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.green);
            Debug.Log("Ground hit: " + hit.collider.name);
            
            return true;
        }
        else
        {
            // Debug information
            Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.red);
            Debug.Log("Ground not hit");
            
            return false;
        }
    }
*/ 

}