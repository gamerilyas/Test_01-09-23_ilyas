using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables pour le deplacement
    public CharacterController cc;
    public float moveSpeed;
    public float jumpForce;
    public float gravity;
    //Vecteur direction souhaitée
    private Vector3 moveDir;
    void Update()
    {
        //
        moveDir = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDir. y, Input.GetAxis("Vertical"));

        if (Input.GetButtonDown("Jump"))
        {
            moveDir.y = jumpForce;
        }
        
        moveDir.y -= gravity * Time.deltaTime;

        if(moveDir.x != 0 || moveDir.z != 0)
        {
            transform.rotation = Quaternion.Slerp( transform.rotation, Quaternion.LookRotation(New Vector3(moveDirDir.x, 0, moveDir.z )), 0.15f );
        }
        cc.Move(moveDir * Time.deltaTime);
    }
}
