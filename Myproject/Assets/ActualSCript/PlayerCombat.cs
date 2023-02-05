using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{    public Animator animator;
  
    void Start() 
    {
      animator=GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
     // bool forwardPressed=Input.GetKeyDown(KeyCode.w);
      if(Input.GetKeyDown(KeyCode.E))  
      {
        Attack();
      }
      void Attack()
      {
           //play an attack animation
           animator.SetTrigger("Attack");
           //detect enemy in range
           //damage them

      }
      if(Input.GetKeyDown(KeyCode.Q))  
      {
        save();
      }
      void save()
      {
           animator.SetTrigger("save");
      }
    if(Input.GetKey(KeyCode.LeftShift))
      { 
        
        animator.SetBool("IsRunning",true);
      }
      else if(!Input.GetKey(KeyCode.LeftShift))
      {
         animator.SetBool("IsRunning",false);
      }
      
      }
    }

