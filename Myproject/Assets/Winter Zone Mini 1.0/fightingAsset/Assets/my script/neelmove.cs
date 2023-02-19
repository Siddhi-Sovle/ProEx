using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neelmove : MonoBehaviour
{    private Animator anim;
     public float Walkspeed=0.001f;
     bool IsJumping=false;
     public GameObject neel;
     public GameObject enemyAI;
     public Vector3 enemyPosition;
     private AnimatorStateInfo NeelLayer0;
     public static bool walkRight=true;
     private bool facingleft=false;
     private bool facingright=false;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponentInChildren<Animator>();
    }
      //restricting move  

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(walkLeft);
        //jumping and crouching
        NeelLayer0=anim.GetCurrentAnimatorStateInfo(0);//base layer is always considered as 0th layer
       if(NeelLayer0.IsTag("motion"))
        {
        if(Input.GetAxis("move")>0)
        {
            anim.SetBool("forwardwalk",true);
            transform.Translate(Walkspeed,0,0);
        }
        if(Input.GetAxis("move")<0)
        {
            anim.SetBool("forwardwalk",true);
             transform.Translate(-Walkspeed,0,0);
        }
        
        if(Input.GetAxis("move")==0)
        {
            anim.SetBool("forwardwalk",false);
             anim.SetBool("backwardwalk",false);
        }
     /*   if(Input.GetAxis("move1")<0)//<0 means downward motion
        {
            anim.SetBool("crouch",true);
           
        }
        if(Input.GetAxis("move1")>0)//>0 means upward motion 
        {
            if(IsJumping==false){
                IsJumping=true;
             anim.SetTrigger("jump");
             StartCoroutine(jumpPause());
            } 
        }
        if(Input.GetAxis("move1")==0)//and ==0 means when no key is pressed
        {
            anim.SetBool("crouch",false);
        }*/
        
        //get opponent position
    // enemyPosition=enemy.transform.position;
     //facing left or the right of opponent
     
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
   
}
