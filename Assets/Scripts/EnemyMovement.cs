﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{


    private int numEnemy = 0;

    public CharacterController2D controller;
    public Animator animator;
 


    public float runSpeed = 40f;

    float horizontalMove = 0f;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = -1 * runSpeed;

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
      
    }


    void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector2(3, 0);
       
    }




}