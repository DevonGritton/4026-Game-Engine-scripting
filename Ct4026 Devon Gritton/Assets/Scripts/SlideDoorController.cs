using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoorController : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject DoorObject;

    private bool DoorIsUp;
    private bool buttonPressed;

    void OnMouseOver()
    {
        buttonPressed = true;
    }

    void OnMouseDown()
    {
        DoorIsUp = !DoorIsUp;
        DoorObject.GetComponent<Animator>().SetBool("DoorIsUp", DoorIsUp);
    }

    void OnMouseExit()
    {
        buttonPressed = false;
    }
    void OnGUI()
    {
        if (buttonPressed == true)
        {
            GUI.Box(
                new Rect(
                    Screen.width / 2 - 100,
                    Screen.height / 2 - 25,
                    200,
                    50),
                    "Press Button"
                    );
        }
    }
}

