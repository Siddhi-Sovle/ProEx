using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neelmoverestrict : MonoBehaviour
{
  public static bool walkLeft=true;
  
  /* private void OnCollisionEnter(Collision col) 
{
    if(col.gameObject.name=="neelrightdetector")
    {
         neelmove.walkLeft=false;//calling this variable present in neelmove script
          Debug.Log("Hi");
    }

  }
  private void OnCollisionExit(Collision col) 
{
    if(col.gameObject.name=="neelrightdetector")
    {
         neelmove.walkLeft=true;//calling this variable present in neelmove script
         Debug.Log("H");
    }

  }*/
   private void OnTriggerEnter(Collider other)
 {
    if(other.gameObject.name=="enemydetector")
    {
        walkLeft=true;//calling this variable present in neelmove script
        Debug.Log(walkLeft);
        
    }

 }
   private void OnTriggerExit(Collider other)
 {
    if(other.gameObject.name=="enenmydetector")
    {
        walkLeft=false;//calling this variable present in neelmove script
         Debug.Log(walkLeft +"'");
    }

 }
}
