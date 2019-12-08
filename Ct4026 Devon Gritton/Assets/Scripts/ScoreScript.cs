using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour// This script is designed to keep track of the amount of coins the player collects throughout the level
{
    public static int scoreValue = 0;
    Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();// assigns scoretext  to a text component
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = scoreValue.ToString();// apends the value of the score variable to the assigned text object in the HUD
    }

}
