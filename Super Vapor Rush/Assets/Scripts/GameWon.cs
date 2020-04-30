using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    //BEGIN CODE BY ME (Ashton Sims)
    public static bool GameIsWon = false;
    public GameObject GameWonUI;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameWon()
    {
        GameWonUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsWon = true;
    }
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
    //END code from (Brackey's)
    //https://www.youtube.com/watch?v=JivuXdrIHK0
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //END code by me (Ashton Sims)
}

