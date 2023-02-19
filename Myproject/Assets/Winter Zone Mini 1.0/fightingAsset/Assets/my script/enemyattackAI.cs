using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AIGame
{
public class enemyattackAI: MonoBehaviour
{
    private Animator anim;
    private AudioSource audio;
    public AudioClip punch;
    public AudioClip kick;
   private static bool hitsAI=false;
   private int AttackNumber=1;
 public enemymoveAI script;
   private bool Attacking=true;
   public float attackaftertime=1.0f;
    // Start is called before the first frame update
    void Start()
    {
         anim=GetComponent<Animator>();
         audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Attacking==true)
        {
            Debug.Log("attack");
       
       if(AttackNumber==1)//fire1 is a ctrl button
        {
            Debug.Log(AttackNumber);
            anim.SetTrigger("punch");
            hitsAI =false;
        }
         if(AttackNumber==2)
        {
            Debug.Log(AttackNumber);
            anim.SetTrigger("roundhouse kick");
            hitsAI =false;
        }
       
        if(AttackNumber==3)
        {
            Debug.Log(AttackNumber);
            anim.SetTrigger("roundhouse kick");
            hitsAI =false;
        }
         if(AttackNumber==5)
        {
            Debug.Log(AttackNumber);
            anim.SetTrigger("roundhouse kick");
            hitsAI =false;
        }
         if(AttackNumber==3)
        {
            Debug.Log(AttackNumber);
            anim.SetTrigger("roundhouse kick");
            hitsAI =false;
        }
         if(AttackNumber==4)
        {
            Debug.Log(AttackNumber);
             anim.SetBool("forwardwalk",false);
            hitsAI =false;
        } 
        }
     
       
    }
     public void RandomAttack()
     {
        if(script.Attackstate==true)
        {
           AttackNumber= Random.Range(1,4);
           StartCoroutine(SetAttacking());
        }
     }  
    IEnumerator SetAttacking()
    {
        yield return new WaitForSeconds(4.1f);
        Attacking=true;
        Debug.Log("1234567688769");
    }
    private void OnTriggerEnter(Collider other) 
    {
        
        if(other.gameObject.tag=="collider")
        {
            
              anim.SetTrigger("bigreact");
           
        }
       
        if(other.gameObject.tag=="handhit")
        { 
            
              anim.SetTrigger("hit");
           
        }
       
        if(other.gameObject.tag=="backflip")
        {
              
              anim.SetTrigger("headhit");
           
        }
       
    }
    
    public void PunchSound()
    {
        audio.clip=punch;//it will basically gonna load this particular audioclip in the AudioClip section in AudioSource Component
        audio.Play();
    }
     public void KickSound()
    {
        audio.clip=kick;//it will basically gonna load this particular audioclip in the AudioClip section in AudioSource Component
        audio.Play();
    }
    
}
}