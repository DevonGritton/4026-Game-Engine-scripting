using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrap : MonoBehaviour
{
    public float ExplosionStrength = 30.0f;
    public float ExplosionRadius = 5.0f;
    public float BombTimer = 3.0f;

    
    public GameObject ExplosionEffect;

    float countdown;
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
            BombTimer -= Time.deltaTime;
        }
        if (BombTimer <= 0 && Exploded == false)
        {

            Explode();
            Exploded = true;
        }
    }
    //private void OnCollisionEnter(Collision collision)
   // {
     //       if (other.gameObject.tag == "Player")
    //        {
    //        Fuzeon = true;
    //    }
   // }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Exploded == false)
        {
            Fuzeon = true;
        }
    }
    void Explode()
    {
        Instantiate(ExplosionEffect, transform.position, transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
        foreach (Collider collider in colliders)
        {
            Rigidbody rigid = collider.GetComponent<Rigidbody>();
            if (rigid != null)
            {
                rigid.AddExplosionForce(ExplosionStrength, transform.position, ExplosionRadius, 0, ForceMode.Impulse);
                if (collider.gameObject.tag == "Player")
                {
                    HealthScript.health -= 5;
                }
            }
        }
        Destroy(gameObject);

    }
}
