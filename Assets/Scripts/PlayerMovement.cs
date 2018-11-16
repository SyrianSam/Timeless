﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    bool crouch = false;


	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", jump);

        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
	}

    public void OnLanding()
    {

        animator.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        //move the player  
        //Time.fixedDeltaTime is the time passed since the last call of fixed update function to ensure that the speed is consistent across platforms 
        controller.Move(horizontalMove * Time.fixedDeltaTime,crouch,jump);
        jump = false;

    }

}