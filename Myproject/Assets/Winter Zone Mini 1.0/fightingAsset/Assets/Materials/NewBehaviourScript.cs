using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public Rigidbody rb;
  void Start() {
    rb=GetComponent<Rigidbody>();
  }
    // Update is called once per frame
    void Update()
  {
        
      if (Input.GetKeyDown(KeyCode.UpArrow))
       {
        rb.AddForce(0,0,800);
       }
     if (Input.GetKeyDown(KeyCode.DownArrow))
       {
        rb.AddForce(0,0,-800);
       }
     if (Input.GetKeyDown(KeyCode.LeftArrow))
       {
        rb.AddForce(800,0,0);
       }
       if (Input.GetKeyDown(KeyCode.RightArrow))
       {
        rb.AddForce(-800,0,0);
       }
    }
}
