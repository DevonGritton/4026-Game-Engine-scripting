using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour// this script is designed to severely damage the player if they fall in the lave in the game
{
    public static bool lavaburn;
    // Start is called before the first frame update.
    void Start()
    {
        lavaburn = false;// at program start sets the boolean to false avoid the player taking damage upon game start.
    }

    // Update is called once per frame.
    void Update()
    {
        if (lavaburn)
        {
            HealthScript.health -= 1;// reduces health value by one every frame if the lava boolean is set to true.
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")// When the player enters the trigger collider set the boolean to true which will initiate the damage every frame
        {
            lavaburn = true;
        }
    }
}
