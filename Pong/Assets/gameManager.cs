using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static int score1 = 0;
    public static int score2 = 0;
    public GUISkin myGUISkin;
    GameObject theBall;
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("theBall");
    }


    void OnGUI()
    {
        GUI.skin = myGUISkin;
        GUI.Label(new Rect(40, 10, 120, 40), "Score 1:" + score1);
        GUI.Label(new Rect(40, 30, 120, 40), "Score 2:" + score2);
        if (score1 == 3)
        {
            //stop the ball, repostion to center
            theBall.SendMessage("hasWon");
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 5, 240, 40), "player 1 has won!");
            if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 60, 40), "Replay:"))
            {
                score1 = 0;
                score2 = 0;
                SceneManager.LoadScene(1);

            }
        }

        if (score2 == 3)
        {
            //stop the ball, repostion to center
            theBall.SendMessage("hasWon");
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 5, 240, 40), "player 2 has won!");
            if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 60, 40), "Replay:"))
            {
                score1 = 0;
                score2 = 0;
                SceneManager.LoadScene(1);

            }
        }
    }
}