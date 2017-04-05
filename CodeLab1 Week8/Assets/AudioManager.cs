using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

    public AudioMixer mixer;
    public List<AudioMixerSnapshot> snapshots;
    public AudioMixerSnapshot currSnapshot;

    public AudioManager instance;

	// Use this for initialization
	void Start () {
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
	void Update () {
        DJ();
	}

    void DJ()
    {
        int score = ScoreManager.currScore;
        AudioMixerSnapshot[] snapshotArray = snapshots.ToArray();

        if (score > 1000000)
        {
            if (currSnapshot != snapshotArray[6])
            {
                snapshotArray[6].TransitionTo(.01f);
            }
        }else
            if (score > 500000)
        {
            if(currSnapshot != snapshotArray[5])
            {
                snapshotArray[5].TransitionTo(.01f);
            }
        }else
            if(score > 250000)
        {
            if (currSnapshot != snapshotArray[4])
            {
                snapshotArray[4].TransitionTo(.01f);
            }
        }
        else
            if(score > 100000)
        {
            if (currSnapshot != snapshotArray[3])
            {
                snapshotArray[3].TransitionTo(.01f);
            }
        }
        else
            if (score > 10000)
        {
            if (currSnapshot != snapshotArray[2])
            {
                snapshotArray[2].TransitionTo(.01f);
            }
        }
        else 
            if (score > 2500)
        {
            if (currSnapshot != snapshotArray[1])
            {
                snapshotArray[1].TransitionTo(.01f);
            }
        }
        else
        {
            if (currSnapshot != snapshotArray[0])
            {
                snapshotArray[0].TransitionTo(.01f);
            }
        }
    }
}
