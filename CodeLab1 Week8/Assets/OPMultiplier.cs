using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPMultiplier : BasicMultiplier {

	// Use this for initialization
	void Start () {
        multiplier = 25;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Shockwave()
    {
        ScoreManager.currScore += ScoreManager.pointValue * multiplier;
    }
}
