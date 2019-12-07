using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoomScript : MonoBehaviour
{
    public Light ColoredLights;
    Color activated = Color.green;//assigns a variable that will store a colour chaneg to green for an assigned light 
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")// if an object with the player tag enters the trigger collider perform the next set of steps 
        {
            if(ColoredLights.color != activated)//if the assigned light is not green then perform the next steps
            {
                ColoredLights.color = activated;// sets the light colour to green
                LightRoomCounter.counter += 1;// increments the light room counter by 1
            }

            if (ColoredLights.color == activated)
            {
                return;// if the light is already green do nothing
            }
        }
    }
}
