using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour // The purpose of this script is to allow the user to pickup both health and coins and apply slight rotational spin to them
{
    bool coin = false;
    bool heart = false;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Coin")
        {
            coin = true;//if a gameobject has a coin tag then coin boolean is true
        }
        if (gameObject.tag == "Health")
        {
            heart = true;//if a gameobject has a health tag then heart boolean is true
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (coin)
        {
            transform.Rotate(new Vector3(Time.deltaTime * 0, 0, 1));// assigns a constant rotational spin to objects that have the tag coin which will turn the boolean coin to true.
        }
        if (heart)
        {
            transform.Rotate(new Vector3(Time.deltaTime * 0, 1, 0));// assigns a constant rotational spin to objects that have the tag Health which will turn the boolean heart to true.
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Coin" && other.gameObject.tag == "Player")//Will only execute the following statement if the Player tag enters an objects trigger with the coin tag
        {
            ScoreScript.scoreValue += 1; //if the condition is true increment the player score by 1
            Destroy(gameObject); // destroys the coin
        }
        if (gameObject.tag == "Health" && other.gameObject.tag =="Player")//Will only execute the following statement if the Player tag enters an objects trigger with the health tag
        {
            HealthScript.health += 1; //if the condition is true increment the player health by 1
            Destroy(gameObject); // destroys the health
        }
    }
}