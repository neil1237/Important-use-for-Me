using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour {

    Paddle paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;
    AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        paddle = GameObject.FindObjectOfType<Paddle>();

        ballPaddleDiff = this.transform.position - paddle.transform.position;
	}

    // Update is called once per frame
    void Update() {

        if (!gameStarted) // if(gameStarted == false)
        {
            this.transform.position = paddle.transform.position + ballPaddleDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.Play();
    }
}
