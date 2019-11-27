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

    // Update is called once per frame
    void Update()
    {
        
        // Used to make the teleporter items bob up and down
        //IF the players enters values the wrong way round the values will flip the direction fo the bob
        // if (transform.position.y >= MaxY ||
        //    transform.position.y <= minY)
        //{
        //sets the bobspeed if the previous conditions are true
        //     BobSpeed = -1.0f;
        // }

        // transform.position += new Vector3(0.0f, BobSpeed * Time.deltaTime, 0.0f);
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

