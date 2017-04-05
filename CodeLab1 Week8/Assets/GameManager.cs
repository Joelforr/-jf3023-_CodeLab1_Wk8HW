using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


    //---PUBLIC FIELD---
    public enum GameState
    {
        Waiting,
        Playing,
        GameOver
    }

    public static GameState gameState;
    public static GameManager instance;

    //---PRIVATE FIELD---
    private const int MAX_TIME = 60;
    private float currTime;

    [SerializeField]
    private Text timeText;

    // Use this for initialization
    void Start () {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        //Intialize the game state
        gameState = GameState.Waiting;

        currTime = (float)MAX_TIME;
	}
	
	// Update is called once per frame
	void Update () {
       
        //DO WHILE WAITING
        if(gameState == GameState.Waiting)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameState = GameState.Playing;
            }
        }


        //DO WHILE PLAYING
        if(gameState == GameState.Playing)
        {
            timeText.text = FormatTime(Mathf.Clamp(currTime, 0, MAX_TIME));
            currTime -= Time.deltaTime;

            if(Mathf.Clamp(currTime, 0 ,MAX_TIME) == 0)
            {
                gameState = GameState.GameOver;
            }
        }

        //DO WHILE GAMEOVER
        if(gameState == GameState.GameOver)
        {
            timeText.text = "00.000";
        }
    }

    public string FormatTime(float time)
    {
        var intTime = Mathf.Floor(time);
        var seconds = intTime;
        var fraction = time * 1000;
        fraction = fraction % 1000;

        string timeText = string.Format("{0:00}.{1:000}", seconds, fraction);
        return timeText;
    }
}
