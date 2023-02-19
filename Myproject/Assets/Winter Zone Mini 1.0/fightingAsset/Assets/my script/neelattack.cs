using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neelattack : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.Q))//fire1 is a ctrl button
        {
            anim.SetTrigger("punch");
        }
         if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("roundhouse kick");
        }
         if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetTrigger("blockOn");
        }
         if(Input.GetKeyUp(KeyCode.Alpha3))
        {
            anim.SetTrigger("blockOff");
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            anim.SetTrigger("swiping");
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
      if(other.gameObject.tag=="enemyleghit")
      {
        anim.SetTrigger("headhit");
      }
      if(other.gameObject.tag=="enemyhandhit")
      {
        anim.SetTrigger("blockOn");
      }
       if(other.gameObject.tag=="enemyhandhit")
      {
        anim.SetTrigger("blockOn");
      }
      if(other.gameObject.tag=="swipinghit")
      {
        anim.SetTrigger("bigreact");
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
