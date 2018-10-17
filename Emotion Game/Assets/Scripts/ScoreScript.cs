using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    public GUISkin mySkin;
    public static int playerScore = 0;

    void Start()
    {

    }


    void Update()
    {

    }

    public static void AddPoints(int pointValue)
    {
        playerScore += pointValue;
    }

    void OnGUI()
    {
        GUI.skin = mySkin;
        GUIStyle style = mySkin.customStyles[0];

        GUI.Label(new Rect(50, Screen.height - 100, 150, 50), "S C O R E :  ");
        GUI.Label(new Rect(200, Screen.height - 100, 130, 50), "" + playerScore);
    }
}
