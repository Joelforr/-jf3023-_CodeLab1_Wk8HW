using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public int spacebarClicks = 0;

	// Use this for initialization
	void Start () {
        //this.gameObject.AddComponent<BasicMultiplier>();
        rb = GetComponent<Rigidbody>();
        UpdateMultiplier(typeof(BasicMultiplier));
	}
	
	// Update is called once per frame
	void Update () {
        //DO WHILE WAITING

        //DO WHILE PLAYING
        if(GameManager.gameState == GameManager.GameState.Playing)
        {
            if (spacebarClicks == 50)
            {
                UpdateMultiplier(typeof(OPMultiplier));
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<BasicMultiplier>().Shockwave();
                spacebarClicks++;
            }

            rb.velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * 5;
            
            
        }
       

        //DO WHILE GAMEOVER
        if(GameManager.gameState == GameManager.GameState.GameOver)
        {
            rb.velocity = Vector3.zero;
        }
	}

    public void UpdateMultiplier(System.Type newMultiplier)
    {
        if (newMultiplier.Equals(GetComponent<BasicMultiplier>()))
        {
            return;
        }
        try
        {
            Destroy(GetComponent<BasicMultiplier>());
        }
        catch(System.Exception e)
        {
            Debug.Log("No Basic Multiplier Attached");
            throw;
        }
        
        this.gameObject.AddComponent(newMultiplier);
    } 
}
