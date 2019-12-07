using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // allows for the use of functions to manage splash screens and menu

public class SplashSequence : MonoBehaviour
{
    public static int SceneNo;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneNo == 0)
        {
            StartCoroutine(ToSplash2());//On start if the player is on the first scene it will begin the sequence to the next scene
        }
        if (SceneNo == 1)
        {
            StartCoroutine(ToMainMenu());//On start if the player is on the first scene it will begin the sequence to the next scene
        }
    }
    IEnumerator ToSplash2()
    {
        yield return new WaitForSeconds (5);
        SceneNo = 1;//after 5 seconds the next splash will appear 
        SceneManager.LoadScene(1);
    }
    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneNo = 2;//after 5 seconds the next splash will appear 
        SceneManager.LoadScene(2);
    }
}
