using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController1 : MonoBehaviour
{
    public GameObject liftObject;

    private bool liftUp;
    private bool buttonPressed;

    void OnMouseOver()
    {
        buttonPressed = true;// when the player hovers over the gameobject the variable value will be set to true
    }

    void OnMouseDown()
    {
        liftUp = !liftUp; // the value for liftup is switched to it's opposite
        liftObject.GetComponent<Animator>().SetBool("LiftIsUp", liftUp);// the animator component is retrieved from the assigned public game object and bool LiftIsUp is set to the value of LiftUp (true)
    }

    void OnMouseExit()
    {
        buttonPressed = false;//sets the value of the variable to false when the users mouse is away from the gameobject
    }
    void OnGUI()// sets up a gui pop up
    {
        if (buttonPressed == true)// sets the boolean to ture which will create a pop up to notify the user to click the button
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
