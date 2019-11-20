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
            StartCoroutine(ToSplash2());
        }
        if (SceneNo == 1)
        {
            StartCoroutine(ToMainMenu());
        }
    }
    IEnumerator ToSplash2()
    {
        yield return new WaitForSeconds (5);
        SceneNo = 1;
        SceneManager.LoadScene(1);
    }
    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneNo = 2;
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
