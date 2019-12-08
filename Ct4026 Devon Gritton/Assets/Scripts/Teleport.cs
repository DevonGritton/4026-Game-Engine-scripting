using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Teleport : MonoBehaviour// this script is designed to teleport the player from one location to another with the press of a button
{
    private bool UI;
    bool buttonPressed;

    private GameObject[] destinations;// defines an array

    // Start is called before the first frame update
    void Start()
    {
        destinations = GameObject.FindGameObjectsWithTag("TeleportDestination"); // Upon game start will collect all game objects with teh tag TeleportDestination and store them into an array
    }
    void OnMouseDown()
    {
        buttonPressed = true;// when the player clicks this variable will be set to true
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            return;//If anything other than the player enters the trigger do nothing
        }
        if (buttonPressed == true)
        {
            destinations = destinations.OrderBy(p => Vector3.Distance(transform.position, p.transform.position)).ToArray();
            other.gameObject.transform.position = destinations[0].transform.position;
            buttonPressed = false;// If the user clicks on the button teleport them to the position of the gameobjects that were found in the destinations array with the TeleportDestinations tag
        }
    }


    private void OnMouseOver()
    {
        UI = true;
    }
    private void OnMouseExit()
    {
        UI = false;
    }
    private void OnGUI()
    {
        if (UI == true)// If the Ui is enabled the following code will display a prompt to notify the user that they are hovering over a teleporter button
        {
            GUI.Box(
                new Rect(
                    Screen.width / 2 - 100,
                    Screen.height / 2 - 25,
                    200,
                    50),
                    "Teleporter Button"
                    );
        }
    }
}

