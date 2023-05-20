using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public static int numEnemy = 0;
    public CharacterController2D controller;
    public Animator animator;
    public GameObject enemy;
    public float runSpeed = 40f;
    private float horizontalMove = 0f;
    private bool jump = false;

    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public static int numEnemy = 0;
    public CharacterController2D controller;
    public Animator animator;
    public GameObject enemy;
    public float runSpeed = 40f;
    private float horizontalMove = 0f;
    private bool jump = false;

    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
        horizontalMove = -1 * runSpeed;
    }

    private void FixedUpdate()
    {
        if (runSpeed > 200)
        {
            jump = true;
        }

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        runSpeed += 0.1f;
        jump = false;
    }

    private void OnBecameInvisible()
    {
        if (runSpeed < 300)
        {
            if (runSpeed < 200 && numEnemy < 4)
            {
                gameObject.transform.position = new Vector2(3, 0);
            }

            if (runSpeed > 200 && numEnemy < 4)
            {
                gameObject.transform.position = new Vector2(3, 0);
                for (int i = 0; i < 1; i++)
                {
                    Instantiate(enemy, new Vector3(i * 2.0F, i * 1.0F, 0), Quaternion.identity);
                }
                numEnemy++;
            }

            gameObject.transform.position = new Vector2(3, 0);
        }
        else
        {
            gameObject.transform.position = new Vector2(3, 0);
            transform.localScale = new Vector3(6.0F, 6.0F, 0);
        }
    }
}
