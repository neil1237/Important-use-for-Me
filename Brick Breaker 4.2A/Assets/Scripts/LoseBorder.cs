using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBorder : MonoBehaviour {

    LevelManager levelManager = new LevelManager(); // created an instance/copy of Level manager

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        levelManager.LoadNewScene("Lose");
    }

    
}
