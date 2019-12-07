using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// used to navigate between scenes

public class MainMenu : MonoBehaviour
{
    // function defining the play button
    public void Play()
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);// when the script is called the scene will move forward by 1
        }
    }
    public void back ()
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);// when the script is called the scene will move backwards by 2
        }
    }
    public void Quit()
    {
        //when the quit function is called the application will close.
        Application.Quit(); 
    }
}
