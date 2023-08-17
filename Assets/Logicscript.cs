using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.AI;

public class Logicscript : MonoBehaviour

{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public int highScore = 0;
    public Text highscoreText;
    public GameObject PressToPlay;
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    private void Start()
    {
        PauseGame();
        highscoreText.text = $"Highscore = {PlayerPrefs.GetInt("hiScore", 0)}";


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
            ResumeGame();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    void PauseGame()
    {
        Time.timeScale = 0;
        PressToPlay.SetActive(true);
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        PressToPlay.SetActive(false);
    }

    public void gameOver()
    {

        Debug.Log(highScore);
        if (playerScore > PlayerPrefs.GetInt("hiScore", highScore))
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("hiScore", highScore);
            PlayerPrefs.Save();

        }
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }


}