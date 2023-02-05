using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    //variables
    [SerializeField] private float walkspeed;
    [SerializeField] private float runspeed;
    [SerializeField] private float moveSpeed;
    private Vector3 moveDirection;
    private Vector3 velocity;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundDistance;
    [SerializeField] private LayerMask GroundMask;
    [SerializeField] private float Gravity;

    [SerializeField] private float JumpHeight;
    //references
    private CharacterController controller;
   // private Animator anim;
     private void Start() 
    {
        controller=GetComponent<CharacterController>();
        //anim=GetComponentInChildren<Animator>();
    }
     public void Update() 
    {
        Move();
       
    }
    private void Move()
    {
      isGrounded=Physics.CheckSphere(transform.position,groundDistance,GroundMask);
      if(isGrounded && velocity.y <0)
      {
        velocity.y=-2f;
      }
      float x=Input.GetAxis("Horizontal");
      float moveZ=Input.GetAxis("Vertical");
      moveDirection=transform.right*x +transform.forward*moveZ;
      //if(isGrounded)
      //{
            if(moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
      {
        //walk
         Walk();
      }
      else if(moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
      {
        //run
          Run();
      }
      else if(moveDirection == Vector3.zero)
      {
        //idle
        idle();
      }
      if(Input.GetKeyDown(KeyCode.Space))
      {
        jump();
      }
       moveDirection =moveDirection*moveSpeed;
      
     
     
      controller.Move(moveDirection*Time.deltaTime);
      velocity.y +=Gravity*Time.deltaTime; //calculate gravity
      controller.Move(velocity*Time.deltaTime);//applying gravity to the player
      
    }
    
      private void idle()
      {
         //anim.SetFloat("speed",0f);
      }
      private void Walk()
      {
           moveSpeed=walkspeed;
           //anim.SetFloat("speed",1f);
      }
      private void Run()
      {
        moveSpeed=runspeed;
         //anim.SetFloat("speed",1f); 
      }
      private void jump()
      {
        velocity.y=Mathf.Sqrt(JumpHeight*-2*Gravity);
        // anim.SetFloat("speed",0f); 
      }
      private void attack()
      {
        //anim.SetTrigger("attack");
      }
    }

