using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerControl : MonoBehaviour
{

    public float _speedPlayer;
    Animator ani;
    PhotonView view;


    void Start()
    {
        view = GetComponent<PhotonView>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            Vector3 moveAmount = moveInput.normalized * _speedPlayer * Time.deltaTime;
            transform.position += moveAmount;
            if(moveInput == Vector3.zero)
            {
                ani.SetBool("IsRunning", false);
            }
            else
            {
                ani.SetBool("IsRunning", true);
            }
        }
        
       
    }
}
