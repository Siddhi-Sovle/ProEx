using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
      public float Sensitivity=100f;
       public Transform Player;
       float xRotate=0f;//roatation along x axis
    // Update is called once per frame
    void Update()
    {
      float MouseX=Input.GetAxis("Mouse X")*Sensitivity*Time.deltaTime;
      float MouseY=Input.GetAxis("Mouse Y")*Sensitivity*Time.deltaTime;
    
     //playerBody.Rotate(Vector3.right*MouseY);agar hum aisa krte hai toh player body will rotate for 360deg  
     xRotate -=MouseY; 
     xRotate=Mathf.Clamp(xRotate,-90f,90f);
     transform.localRotation=Quaternion.Euler(xRotate,0f,0f);
     Player.Rotate(Vector3.up*MouseX);
      }
}
