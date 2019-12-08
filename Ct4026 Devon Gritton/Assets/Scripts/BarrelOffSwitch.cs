using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelOffSwitch : MonoBehaviour
{
    public GameObject Barrels;
    // Start is called before the first frame update
    void Start()
    {
        Barrels.SetActive(true);//On start the assigned barrel spawner vaibles is activated
    }
    //On trigger is called when the player enters the trigger collider for the plate
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.tag == "Player")
            {
                Barrels.SetActive(false);// disables the assigned gameobject so that when the player interacts with the plateIt will disable the barrel spawner
            }
        }
    }
}
