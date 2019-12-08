using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrap : MonoBehaviour //This script is designed to destroy other objects when a player enters the trigger
{
    public GameObject Trap;
    public GameObject Trap2;
    public GameObject Coins1;
    // Start is called before the first frame update
    void Start()
    {
        Coins1.SetActive(false);// deactivates the gameobject assign to teh coins1 variable
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")// if the playe tag enters the collider for this object then
        {
            Coins1.SetActive(true);//activate the coins game object
            Destroy(Trap);// and destroy the trap gameobjects 
            Destroy(Trap2);
        }
    }
}
