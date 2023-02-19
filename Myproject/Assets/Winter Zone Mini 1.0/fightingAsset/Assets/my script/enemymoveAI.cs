using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

public class enemymoveAI : MonoBehaviour
{    private Animator anim;
     public float Walkspeed=0.001f;
     bool IsJumping=false;
     public GameObject neel;
     public GameObject enemy;
     public Vector3 enemyPosition;


    private float distancefromNeel;
    public float attackdistance= 7.75f;
    private bool moveAI=true;
    public  bool Attackstate=false;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //finding out the distance between Ai charcter and Neel
    /*for that we will register the distance in oppdistance var and then by using Vector3.Distance() we will find the distance between AI and neel as Distance() is used
    to find the distance between 2 points A and B */    

    distancefromNeel =Vector3.Distance(neel.transform.position,transform.position);
    if(neel.transform.position.x <transform.position.x)
    {
       Time.timeScale=1.2f;
        anim.SetBool("canAttack",false);
        if(moveAI==true)
        {
         if(distancefromNeel > attackdistance)
        {
          anim.SetBool("forwardwalk",true);
            transform.Translate(Walkspeed,0,0);
            Attackstate=true;
            Debug.Log(distancefromNeel);
           
        }
        }
       if(distancefromNeel < attackdistance)
    {
          if(moveAI==true)
          {
            moveAI=false;
          anim.SetBool("forwardwalk",false);
           anim.SetBool("canAttack",true);
            StartCoroutine(forwardwalkfalse());
          }
           
    }
        }
   
    
    
        //jumping and crouching
       /* if(Input.GetAxis("Horizontal")>0)
        {
            anim.SetBool("forwardwalk",true);
            transform.Translate(Walkspeed,0,0);
        }*/
        
        
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
          if(Input.GetKeyDown(KeyCode.R))
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
    IEnumerator forwardwalkfalse()
    {
        yield return new WaitForSeconds(0.5f);
        moveAI=true;
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
