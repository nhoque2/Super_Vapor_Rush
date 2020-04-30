using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{// BEGIN Code by me (Ashton Sims)
    public static bool GameIsOver = false;
    public GameObject GameOverUI;
    private static double gameOver; //new variable to store current time

    // Update is called once per frame
    void Update()
    {
        gameOver = Timer.current; //updates the time
        if (gameOver <= 0.0)
        {
            GameEnd();
        }
    }
    public void GameEnd()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsOver = true;
    }//END code by me (Ashton Sims)

    //BEGIN code from (Brackey's)
    //https://www.youtube.com/watch?v=JivuXdrIHK0
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //END code from (Brackey's)
    //https://www.youtube.com/watch?v=JivuXdrIHK0
}
