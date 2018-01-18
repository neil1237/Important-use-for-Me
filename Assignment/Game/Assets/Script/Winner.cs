using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {
    public Scores scores;
    public Text Score1, Score2, Wins;

    public void Start () {
        scores.player1Total = PlayerPrefs.GetInt("Player 1 Total");
        scores.player2Total = PlayerPrefs.GetInt("Player 2 Total");
        Score1.text = (scores.player1Total).ToString();
        Score2.text = (scores.player2Total).ToString();
        if (scores.player1Total > scores.player2Total)
        {
            Wins.text = ("The winner is player 1");
        }
        else
            Wins.text = ("The winner is player 2");
    }

        
    }