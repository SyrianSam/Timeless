using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{

    public static int playerPVCounter = 1000;
    public void StartGame()
    {
        // "Stage1" is the name of the first scene we created.
        playerPVCounter = 3;
        SceneManager.LoadScene("MainLevel");
    }

    public void StartGameTest()
    {
        // "Stage1" is the name of the first scene we created.
        playerPVCounter = 1000;
        SceneManager.LoadScene("MainLevel");
    }


}
