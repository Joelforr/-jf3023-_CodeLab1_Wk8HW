using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMultiplier : MonoBehaviour {

    protected int multiplier = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Shockwave()
    {
        ScoreManager.currScore += ScoreManager.pointValue * multiplier;
    }
}
