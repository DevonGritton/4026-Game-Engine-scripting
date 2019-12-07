using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartProjectile : MonoBehaviour
{  
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Enviroment"))
        {
            Destroy(gameObject);// if the game object collides with the enviroment tage destroy it 
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            HealthScript.health -= 1; // if the player enters the darts trigger then they will lose 1 health
        }
    }
}
