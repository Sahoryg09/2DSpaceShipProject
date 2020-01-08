using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int playersLivesNum;
    public Text livesText;
    public Text scoreText;
    public Text endGameText;


    private float highscore;
    private int currentLives;
    private bool gameIsOn;


    // Start is called before the first frame update
    void Start()
    {
        RestartGame();
    }

    private void RestartGame()
    {
        currentLives = playersLivesNum;
        gameIsOn = true;

        livesText.text = "LIVES: " + currentLives;
        highscore = 0;

        endGameText.text = "";
    }
    // Update is called once per frame
    void Update()
    {
        if (gameIsOn)
        {
            highscore += Time.deltaTime * 10;
            scoreText.text = "SCORE: " + System.Math.Round(highscore, 1);
        }

        if (Input.GetKeyDown("r"))
        {
            RestartGame();
        }
    }
    public void UpdatePlayersLives(int amount)
    {
        if (!gameIsOn)
            return;

        currentLives += amount;
        Debug.Log("LIVES: " + currentLives);
        livesText.text = "LIVES: " + currentLives;

        if (currentLives <= 0)
        {
            gameIsOn = false;
            Debug.Log("Game is Over!");
            endGameText.text = "You have ran out of Lives! Game OVER" + "\n Press R to restart!";
        }


    }
}
