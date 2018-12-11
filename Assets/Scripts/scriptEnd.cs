using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptEnd : MonoBehaviour {



    private int numEnemy = 0;

	
	// Update is called once per frame
	void Update () {
		
	}
    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
          

            if (numEnemy < 5)
            {
                Instantiate(col.gameObject, new Vector2(5, 0), Quaternion.identity);
                Instantiate(col.gameObject, new Vector2(10, 0), Quaternion.identity);
                numEnemy++;
            }
            else
            {
                numEnemy--;
            }
            Destroy(col.gameObject);
        }
    }
}
