using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // used to navigate through the scenes

public class DeathScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (HealthScript.health <= 0)// if player health is less than or = to 0
        {
            SceneManager.LoadScene("DeathMenu");// loads the death menu scene
        }
    }
}
