using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
    bool gameStarted = false;
    public Scores scores;
    private Rigidbody2D rb;
    public static bool WasGoal { get; private set; }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        WasGoal = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D value)
    {
        if (!WasGoal)
        {
            if (value.tag == "Player1Score")
            {
                scores.Increment(Scores.Score.Player1Score);
                WasGoal = true;
                StartCoroutine(ResetBall());
            }
            else 
            {
                scores.Increment(Scores.Score.Player2Score);
                WasGoal = true;
                StartCoroutine(ResetBall());
            }
        }
    }

    private IEnumerator ResetBall()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        WasGoal = false;
        rb.position = new Vector3(0,0,0);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        gameStarted = false;
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
        }
    }

}
