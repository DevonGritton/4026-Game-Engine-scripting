using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private float MaxY;

    [SerializeField]
    private float minY;

    [SerializeField]
    private float BobSpeed;

    private bool UI;
    bool buttonPressed;

    private GameObject[] destinations;

    // Start is called before the first frame update
    void Start()
    {
        
        destinations = GameObject.FindGameObjectsWithTag("TeleportDestination");
    }
    void OnMouseDown()
    {
        buttonPressed = true;
    }
    
 
    private void OnTriggerStay(Collider other)
    {
        if (other .gameObject.tag != "Player")
        {
            return;
        }
        if (buttonPressed == true)
        {
            destinations = destinations.OrderBy(p => Vector3.Distance(transform.position, p.transform.position)).ToArray();
            other.gameObject.transform.position = destinations[0].transform.position;
            buttonPressed = false;
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
        if (UI == true)
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

