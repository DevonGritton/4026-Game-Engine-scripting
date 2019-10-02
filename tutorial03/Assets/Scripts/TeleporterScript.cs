using System.Collections;
using System.Collections.Generic;
using System.Linq; // For the order by command
using UnityEngine;

public class TeleporterScript : MonoBehaviour
{
    //Max y position in bobbing motion
    [SerializeField]
    private float MaxY;

    //Min Y position in bobbing motion
    [SerializeField]
    private float MinY;

    //Speed of the bobbing motion
    [SerializeField]
    private float BobSpeed;

    private GameObject[] destinations;

    private void Start()
    {
        // Retrieve a list of all objects tagged as a tp destination
        //Stored in the variables destinations
        destinations = GameObject.FindGameObjectsWithTag("TeleportDestination");
    }
    // Update is called once per frame
    private void Update()
    {
        //The current y position is greater than or less to the minimum or maximum y value
        if (transform.position.y >= MaxY ||
            transform.position.y <= MinY)
            //Then teleport the player
        {
            BobSpeed *= -1.0f;
        }
        //Move the sphere/teleporter
        transform.position += new Vector3(0.0f, BobSpeed * Time.deltaTime, 0.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        //If anything other than the player collides with the teleporter nothing happens
        //If the player collides with it they are teleported
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        else
        {
            // Sort the array of destination by which is closests to the current object positions
            destinations = destinations.OrderBy(p => Vector3.Distance(transform.position, p.transform.position)).ToArray();
            other.gameObject.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.position = destinations[0].transform.position;
            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}