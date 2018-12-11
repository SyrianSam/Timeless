using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{


    public static int numEnemy = 0;

    public CharacterController2D controller;
    public Animator animator;
    public GameObject enemy;
    //public static bool jumpVar = true;
    bool jump = false;




    public float runSpeed = 40f;

    float horizontalMove = 0f;
    int levelCounter = 0;

    private void Start()
    {

        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
    // Update is called once per frame
    void Update()
    {

       

            horizontalMove = -1 * runSpeed;
       

       

    }

    void FixedUpdate()
    {
        // Move our character
        if(runSpeed > 200)
        {
            jump = true;

        }
     
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
     
        runSpeed += 0.1f;
        jump= false;
    

            // scale the object up by 0.1
         //   transform.localScale += new Vector3(0.1F, 0.1F, 0);
     
        


    }
    
    void OnBecameInvisible()
    {

        if (runSpeed < 300)
        {
            if (runSpeed < 200 && numEnemy < 4)
                gameObject.transform.position = new Vector2(3, 0);

            if (runSpeed > 200 && numEnemy < 4)
            {
                gameObject.transform.position = new Vector2(3, 0);
                for (int i = 0; i < 1; i++)
                {
                    //  Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                    Instantiate(enemy, new Vector3(i * 2.0F, i * 1.0F, 0), Quaternion.identity);
                }
                numEnemy++;
            }


            gameObject.transform.position = new Vector2(3, 0);

        }
        else {
            //Instantiate(enemy, new Vector3(3.0F, 1.0F, 0), Quaternion.identity);
            gameObject.transform.position = new Vector2(3, 0);
            transform.localScale = new Vector3(6.0F, 6.0F, 0);
          
            
        }

        /*
        if (runSpeed > 300 && numEnemy < 3f)
        {
            gameObject.transform.position = new Vector2(3, 0);
            for (int i = 0; i < 1; i++)
            {
                //  Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                Instantiate(enemy, new Vector3(i * 2.0F, i * 1.0F, 0), Quaternion.identity);
            }
            numEnemy++;
        }

        if (runSpeed > 400 && numEnemy < 4f)
        {
            gameObject.transform.position = new Vector2(3, 0);
            for (int i = 0; i < 1; i++)
            {
                //  Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                Instantiate(enemy, new Vector3(i * 2.0F, i * 1.0F, 0), Quaternion.identity);
            }
            numEnemy++;
        }
        */

    }




}