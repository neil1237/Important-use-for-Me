using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour {

    Paddle paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;
    AudioSource audio;
    AudioClip crackSound;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        paddle = GameObject.FindObjectOfType<Paddle>();
        crackSound = Resources.Load("Sounds/crack") as AudioClip;
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
        GameObject collisionObject = collision.gameObject;
        if (collisionObject.tag != "Breakable" && gameStarted)
        {
            audio.Play();
        }
        else if (collisionObject.tag == "Breakable")
        {
            audio.PlayOneShot(crackSound);
        }
    }
}
