using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject liftObject;

    private bool liftUp;
    private bool buttonPressed;

    void OnMouseOver()
    {
        buttonPressed = true;
    }

    void OnMouseDown()
    {
        liftUp = !liftUp;
        liftObject.GetComponent<Animator>().SetBool("LiftIsUp", liftUp);
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
