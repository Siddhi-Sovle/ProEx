using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    private Animator anim;
    private AudioSource audio;
    public AudioClip punch;
    public AudioClip kick;
    // Start is called before the first frame update
    void Start()
    {
         anim=GetComponent<Animator>();
         audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))//fire1 is a ctrl button
        {
            anim.SetTrigger("punch");
        }
         if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("roundhouse kick");
        }
                 if(Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("blockOn");
        }
         if(Input.GetKeyUp(KeyCode.Q))
        {
            anim.SetTrigger("blockOff");
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("swiping");
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("swiping");
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="collider")
        {
              anim.SetTrigger("bigreact");
           
        }
        if(other.gameObject.tag=="handhit")
        {
              anim.SetTrigger("headhit");
           
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
