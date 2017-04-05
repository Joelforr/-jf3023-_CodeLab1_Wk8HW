using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int currScore;
    public static int highScore;

    public static int pointValue = 100;

    [SerializeField]
    private Text scoreText;

    public static ScoreManager instance;

    // Use this for initialization
    void Start() {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update() {
        scoreText.text = currScore.ToString("000000000");
    }


}
