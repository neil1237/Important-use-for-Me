using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public string levelName;
    public GameObject button1;
    public Ball ball;
    
    public enum Score
    {
        Player1Score, Player2Score
    }

    public void Start()
    {
        button1.gameObject.SetActive(false);
        
        Scene thisScene = SceneManager.GetActiveScene();
        string levelName = thisScene.name;
        
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active scene is '" + scene.name + "'.");
    }

    public Text Player1Txt, Player2Txt;

    public int player1Scores, player2Scores, player1Total,player2Total;
    


    public void Increment(Score whichScore)
    {
        
        /*Level 1*/
        if (levelName == "Level 1")
        {
            if (whichScore == Score.Player1Score)
            {
                Player1Txt.text = (++player1Scores).ToString();
            }
            else if (whichScore == Score.Player2Score)
            {
                Player2Txt.text = (++player2Scores).ToString();
            }

            if (player1Scores == 5)
            {
                player1Total = player1Scores;
                player2Total = player2Scores;
                PlayerPrefs.SetInt("Player 1 Total", player1Total);
                PlayerPrefs.SetInt("Player 2 Total", player2Total);
                Player1Txt.text = "Winner";
                button1.gameObject.SetActive(true);
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            }
            else if (player2Scores == 5)
            {
                player1Total = player1Scores;
                player2Total = player2Scores;
                PlayerPrefs.SetInt("Player 1 Total", player1Total);
                PlayerPrefs.SetInt("Player 2 Total", player2Total);
                Player2Txt.text = "Winner";
                button1.gameObject.SetActive(true);
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            }
            Debug.Log("Player1 " + player1Total + " Player 2 "+ player2Total);
        }
        
        else if (levelName == "Level 2")
        {

            if (whichScore == Score.Player1Score)
            {
                player1Scores = player1Scores + 2;
                Player1Txt.text = (++player1Scores).ToString();
                Debug.Log("Player1 " + player1Scores);
            }
            else if (whichScore == Score.Player2Score)
            {
                player2Scores = player2Scores + 2;
                Player2Txt.text = (++player2Scores).ToString();
                Debug.Log("Player2 " + player2Scores);
            }

            if (player1Scores == 9)
            {
                player1Total = PlayerPrefs.GetInt("Player 1 Total");//tahdem minajra 
                player2Total = PlayerPrefs.GetInt("Player 2 Total");//tahdem minajra 
                player1Total = player1Scores + player1Total;
                player2Total = player2Scores + player2Total;
                PlayerPrefs.SetInt("Player 1 Total", player1Total);
                PlayerPrefs.SetInt("Player 2 Total", player2Total);
                Player1Txt.text = "Winner";
                button1.gameObject.SetActive(true);
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            }
            else if (player2Scores == 9)
            {
                player1Total = PlayerPrefs.GetInt("Player 1 Total");//tahdem minajra 
                player2Total = PlayerPrefs.GetInt("Player 2 Total");//tahdem minajra 
                player1Total = player1Scores + player1Total;
                player2Total = player2Scores + player2Total;
                PlayerPrefs.SetInt("Player 1 Total", player1Total);
                PlayerPrefs.SetInt("Player 2 Total", player2Total);
                Player2Txt.text = "Winner";
                button1.gameObject.SetActive(true);
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

            }
            Debug.Log("Player1 " + player1Total + " Player 2 " + player2Total);
        }
        else if (levelName == "Level 3")
        {

            if (whichScore == Score.Player1Score)
            {
                player1Scores = player1Scores + 4;
                Player1Txt.text = (++player1Scores).ToString();
            }
            else if (whichScore == Score.Player2Score)
            {
                player2Scores = player2Scores + 4;
                Player2Txt.text = (++player2Scores).ToString();
            }

            if (player1Scores == 20)
            {
                player1Total = PlayerPrefs.GetInt("Player 1 Total");
                player2Total = PlayerPrefs.GetInt("Player 2 Total");
                player1Total = player1Scores + player1Total;
                player2Total = player2Scores + player2Total;
                PlayerPrefs.SetInt("Player 1 Total", player1Total);
                PlayerPrefs.SetInt("Player 2 Total", player2Total);
                Player1Txt.text = "Winner";
                button1.gameObject.SetActive(true);
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            }
            else if (player2Scores == 20)
            {
                player1Total = PlayerPrefs.GetInt("Player 1 Total");
                player2Total = PlayerPrefs.GetInt("Player 2 Total");
                player1Total = player1Scores + player1Total;
                player2Total = player2Scores + player2Total;
                PlayerPrefs.SetInt("Player 1 Total", player1Total);
                PlayerPrefs.SetInt("Player 2 Total", player2Total);
                Player2Txt.text = "Winner";
                button1.gameObject.SetActive(true);
                ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

            }
            Debug.Log("Player1 " + player1Total + " Player 2 " + player2Total);
        }
    }
}

