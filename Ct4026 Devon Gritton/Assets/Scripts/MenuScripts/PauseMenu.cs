using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// used to navigate across scenes

public class PauseMenu : MonoBehaviour//This script allows for the game to be paused by pressing escape and navigate back to the main menu if needed
{

    public static bool GamePause = false;
    public GameObject PauseMenuelements;

    // Update is called once per frame.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//detects if the user presses the escape button.
        {
            if (GamePause)
            {
                Resume();// calls the resume function if the game is paused while pressing escape button.
            }
            else
            {
                Pause();// calls the pause function if the game is running while pressing escape button.
            }
        }
    }
    public void Resume()// this function when called wil lclose the pause menu and resume the game.
    {
        PauseMenuelements.SetActive(false);// deactivated the pause menu.
        Time.timeScale = 1f;//Sets the time to default speed.
        GamePause = false;// sets the pause variable to false to call the appropriette functions when escape is pressed again
    }
    void Pause()// This function will pause the current game and enable the pause menu
    {
        PauseMenuelements.SetActive(true);//activates the pause menu elements.
        Time.timeScale = 0f;//freezes time so the game isnt playing in the background 
        GamePause = true;// sets the pause variable to true to call the appropriette functions when escape is pressed again
    }
    public void Quit()
    {
        Application.Quit();//When called this function will quit the application
    }
    public void Menu()
    {
        Time.timeScale = 1f;// sets the timescale to normal to avoid the game being frozen when going in and out of the menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);// navigates backwards to the main menu
    }
}
