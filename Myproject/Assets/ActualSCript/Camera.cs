using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    public Transform player;
    public float smoothSpeed =0.125f;
    public Vector3 offset;
    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position=player.position +offset;
    }
}

