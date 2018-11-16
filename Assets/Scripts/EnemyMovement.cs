using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {


    public CharacterController2D controller;


    public float runSpeed = 40f;
    
        

    float horizontalMove = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        horizontalMove = -runSpeed;

    }


    private void FixedUpdate()
    {
        //move the player  
        //Time.fixedDeltaTime is the time passed since the last call of fixed update function to ensure that the speed is consistent across platforms 
        controller.Move( - runSpeed * Time.fixedDeltaTime, false, false);
     

    }
}
