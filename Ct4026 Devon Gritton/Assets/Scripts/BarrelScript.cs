using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour// this script defines when the barrel shall explode and how much damage it will do to the player when it collides with them
{
    public GameObject Effect;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 7.0f;
    }
    private void OnCollisionEnter(Collision other) // will call when the object collides with another
    {
        if (other.collider.CompareTag("Enviroment")) // if the barrel collides with another object tagged with enviroment
        {
            Instantiate(Effect, transform.position, transform.rotation);//activates the assigned particle effect
            Destroy(gameObject);// destroys the barrel
        }
        if (other.collider.CompareTag("Player"))
        {
            Instantiate(Effect, transform.position, transform.rotation);//activates the assigned particle effect
            HealthScript.health -= 2;//reduces the players health by 2 if they get hit by a barrel
            Destroy(gameObject);// destroys the barrel
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HealthScript.health -= 2;//reduces the players health by 2 if they get hit by a barrel
        }
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;// reduces the timer in real time
        if (timer <= 0)// if the timer is less than or = to 0
        {
            Instantiate(Effect, transform.position, transform.rotation);// if the barrel has not collided with anything after the timer has run out then activate the particle effect anyway
            Destroy(gameObject);// destroys the barrel
        }
    }
}
