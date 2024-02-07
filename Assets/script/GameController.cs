using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject ScoreText;
    public GameObject TapToStart;
    public void Start()
    {
        gameOverPanel.SetActive(false);
        TapToStart.SetActive(true);
        ScoreText.SetActive(false);
        PauseGame();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space) )
        {
            StartGame();
        }
    }
    // Update is called once per frame
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        ScoreText.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        ScoreText.SetActive(true);
        TapToStart.SetActive(false);
        Time.timeScale = 1f;
    }
}
