using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject liftObject;

    private bool liftUp;
    private bool buttonPressed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
