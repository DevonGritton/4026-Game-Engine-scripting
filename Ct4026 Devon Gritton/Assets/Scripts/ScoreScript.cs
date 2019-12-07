using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
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
