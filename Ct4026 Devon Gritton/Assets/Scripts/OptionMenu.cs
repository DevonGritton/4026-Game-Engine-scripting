using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionMenu : MonoBehaviour
{
    Resolution[] resolutions;

    public Dropdown ResDrop;
    private void Start()
    {
        resolutions = Screen.resolutions;

        ResDrop.ClearOptions();

        List<string> options = new List<string>();
        int CurrentRes = 0;
        
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                CurrentRes = i;
            }
        }

        ResDrop.AddOptions(options);
        ResDrop.value = CurrentRes;
        ResDrop.RefreshShownValue();
    }
    public void SetResolution(int ResIndex)
    {
        Resolution resolution = resolutions[ResIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void setBrightness (float brightness)
    {

        Debug.Log(brightness);
    }
    public void fullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }

}
