using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrap : MonoBehaviour//This script is designed to make a bomb explode when the player enters it's radius propel all rigidbodies by a defined distance and do damage to the player 
{
    public float ExplosionStrength = 30.0f;
    public float ExplosionRadius = 5.0f;
    public float BombTimer = 3.0f;

    
    public GameObject ExplosionEffect;
    bool Fuzeon = false;
    bool Exploded;
    private void Start()
    {
        Exploded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fuzeon == true && Exploded == false)
        {
            BombTimer -= Time.deltaTime;// if the fuze has been lit while the bomb is not yet exploded it will begin to countdown
        }
        if (BombTimer <= 0 && Exploded == false)
        {
            Explode();
            Exploded = true;//When the countdown reaches 0 the bomb will call the explode function and explode
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Exploded == false)
        {
            Fuzeon = true; //When the player enters the trigger of the object and it has not yet exploded the fuze will be set to true
        }
    }
    void Explode()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);// performs the particle effect explosion
        Collider[] colliders = Physics.OverlapSphere(transform.position, ExplosionRadius);// creates an array of colliders that are within the explosion radius of the bomb
        foreach (Collider collider in colliders)//will perform the same function below for all objects with colliders in teh collider array
        {
            Rigidbody rigid = collider.GetComponent<Rigidbody>();// retrieved all rigidbody components in the explosion radius of the bomb
            if (rigid != null)
            {
                rigid.AddExplosionForce(ExplosionStrength, transform.position, ExplosionRadius, 0, ForceMode.Impulse);//Propels all objects with rigidbodies in explosion radius of the bomb by the explosion strength value 
                if (collider.gameObject.tag == "Player")
                {
                    HealthScript.health -= 5;// reduces the player health by 5 if they are in the blast radius of the bomb
                }
            }
        }
        Destroy(gameObject);//destroys the game object when it explodes 
    }
}
