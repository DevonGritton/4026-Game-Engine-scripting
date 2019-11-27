using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSettings : MonoBehaviour
{
    float brightness;
    // Start is called before the first frame update
    void Start()
    {
        // Loads the value the player selected for the brightness in the options menu
        //And applies it to the current scene
        brightness = PlayerPrefs.GetFloat("UserBrightness", 0);
        RenderSettings.ambientLight = new Color(brightness, brightness, brightness, 1);
        Debug.Log(brightness);

        PlayerPrefs.SetFloat("UserBrightness", brightness);
    }


  
}
