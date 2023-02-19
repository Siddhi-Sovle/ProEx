using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{    private Animator anim;
     public float Walkspeed=0.001f;
     bool IsJumping=false;
     public GameObject neel;
     public GameObject enemy;
     public Vector3 enemyPosition;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //jumping and crouching
        if(Input.GetAxis("Horizontal")>0)
        {
            anim.SetBool("forwardwalk",true);
            transform.Translate(Walkspeed,0,0);
        }
        if(Input.GetAxis("Horizontal")<0)
        {
            anim.SetBool("forwardwalk",true);
             transform.Translate(-Walkspeed,0,0);
        }
        if(Input.GetAxis("Horizontal")==0)
        {
            anim.SetBool("forwardwalk",false);
             anim.SetBool("backwardwalk",false);
        }
        if(Input.GetAxis("Vertical")<0)//<0 means downward motion
        {
            anim.SetBool("crouch",true);
           
        }
        if(Input.GetAxis("Vertical")>0)//>0 means upward motion 
        {
            if(IsJumping==false){
                IsJumping=true;
             anim.SetTrigger("jump");
             StartCoroutine(jumpPause());
            } 
        }
        if(Input.GetAxis("Vertical")==0)//and ==0 means when no key is pressed
        {
            anim.SetBool("crouch",false);
        }
          if(Input.GetKeyDown(KeyCode.E))
    {
        anim.SetBool("Knockedout",true);
    }
         
        //get opponent position
     enemyPosition=neel.transform.position;
        //flip around to face Opponent
       /* if(enemyPosition.x>transform.position.x)
        {
            StartCoroutine(LeftIsTrue()); 
        }
        if(enemyPosition.x<transform.position.x)
        {
            StartCoroutine(RightIsTrue()); 
        }*/
    }
    
    IEnumerator jumpPause()
    {
        yield return new WaitForSeconds(1.0f);
        IsJumping=false;
    }
   /* IEnumerator LeftIsTrue()
    {
        yield return new WaitForSeconds(0.15f);
        transform.Rotate(0,-180,0);
    }
     IEnumerator RightIsTrue()
    {
        yield return new WaitForSeconds(0.15f);
        transform.Rotate(0,180,0);
    }*/
     /*private void OnTriggerEnter(Collider other) 
    {
      anim.SetTrigger("knockedout");
    }*/
   
}
