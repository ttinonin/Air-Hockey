using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0; // Pontuação do player 1
    public static int PlayerScore2 = 0; // Pontuação do player 2

    public GUISkin layout;              // Fonte do placar
    GameObject theBall;
    // Start is called before the first frame update
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    void SelectFirstPlayer() {
        int number = Random.Range(1,3);
        Debug.Log("Numero: "+number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Score (string golID) {
        if (golID == "Gol1")
        {
            PlayerScore1++;
        } else
        {
            PlayerScore2++;
        }
    }
    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width/2+20, 100, 500, 500), "AAA" + PlayerScore1);
        GUI.Label(new Rect(Screen.width/2+20, 100, 500, 500), "AAA" + PlayerScore2);

        if (GUI.Button(new Rect(Screen.width/2+20, 35, 120, 50), "RESTART"))
        {
            PlayerScore1 = 0;
            PlayerScore2 = 0;
            theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
        }
        if (PlayerScore1 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        } else if (PlayerScore2 == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
            theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
        }
    }


}
