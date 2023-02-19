using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
   public Rigidbody Rb;
   void Start() {
    Rb=GetComponent<Rigidbody>();
   }
    // Update is called once per frame
    void Update()
    {
        Rb.AddForce(0,0,100);
    }
}
