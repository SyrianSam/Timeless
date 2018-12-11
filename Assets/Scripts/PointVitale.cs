using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointVitale : MonoBehaviour
{
    
    public Text pvText;

    public static int pvCounter = MenuScript.playerPVCounter;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        pvText.text = pvCounter.ToString("0");

    }
}
