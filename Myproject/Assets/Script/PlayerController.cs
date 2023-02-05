using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed,gravityModifier,jumpPower;
    public CharacterController charCon;
    private Vector3 moveInput;
    public Transform camTrans;
    public Animator anim;
    public GameObject bullet;
    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        // moveInput.x = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // moveInput.z = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yStore = moveInput.y;
        Vector3 vertMove = transform.forward * Input.GetAxis("Vertical");
        Vector3 horiMove = transform.right * Input.GetAxis("Horizontal");
        moveInput = horiMove + vertMove;
        moveInput = moveInput * moveSpeed;

        moveInput.y = yStore;

        moveInput.y += Physics.gravity.y * gravityModifier * Time.deltaTime;

        if(charCon.isGrounded)
        {
            moveInput.y = Physics.gravity.y * gravityModifier * Time.deltaTime;
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            moveInput.y = jumpPower;
        }

        charCon.Move(moveInput * Time.deltaTime);

        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y + mouseInput.x,transform.rotation.eulerAngles.z);
        camTrans.rotation = Quaternion.Euler(camTrans.rotation.eulerAngles.x - mouseInput.y,camTrans.rotation.eulerAngles.y,camTrans.rotation.eulerAngles.z);

        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }

        anim.SetFloat("moveSpeed", moveInput.magnitude);
    }
}
