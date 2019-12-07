using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoomScript : MonoBehaviour
{
    public Light ColoredLights;
    Color activated = Color.green;


    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if(ColoredLights.color != activated)
            {
                ColoredLights.color = activated;
                LightRoomCounter.counter += 1;
            }

            if (ColoredLights.color == activated)
            {
                return;
            }
        }
        if (ColoredLights.color == activated)
        {

        }

    }

    // Update is called once per frame
    void Update()
    {
       //if (Activated)
       // {
       //     counter += 1;
       //     Debug.Log(counter);
       // }
    }
}
