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
        buttonPressed = true;//sets the boolean to true so a message prompt will appear when the players mouse over the trigger collider 
    }

    void OnMouseDown()
    {
        DoorIsUp = !DoorIsUp;
        DoorObject.GetComponent<Animator>().SetBool("DoorIsUp", DoorIsUp);
    }

    void OnMouseExit()
    {
        buttonPressed = false;// when the player hovers away from the designated obejc the prompt will disapear since the boolean is set to false 
    }
    void OnGUI()
    {
        if (buttonPressed == true)// if the button variable is true this will create a message prompt box for the player to click the button
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

