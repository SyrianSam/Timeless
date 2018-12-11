using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTestScript : MonoBehaviour {

    public void StartGame()
    {
        // "Stage1" is the name of the first scene we created.

      
        SceneManager.LoadScene("MainLevel");
    }

}
