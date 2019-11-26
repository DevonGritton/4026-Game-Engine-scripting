using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrap : MonoBehaviour
{
    public float ExplosionStrength = 30.0f;
    public float ExplosionRadius = 5.0f;
    public float BombTimer = 3.0f;
    float countdown;
    bool Fuzeon = false;

    // Update is called once per frame
    void Update()
    {
        if (Fuzeon == true)
        {
            BombTimer -= Time.deltaTime;
        }
        if (BombTimer <= 0)
        {
            Explode();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "Player")
            {
            Fuzeon = true;
        }
    }
   // private void OnTriggerEnter(Collider other)
   // {
      //  if (BombTimer <= 0)
      //  {


       //     Collider[] colliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
      //      foreach (Collider collider in colliders)
       //     {
      //          Rigidbody rigid = collider.GetComponent<Rigidbody>();
      //          if (rigid != null)
      //          {
      //              rigid.AddExplosionForce(ExplosionStrength, transform.position, ExplosionRadius, 0, ForceMode.Impulse);
      //          }
      //      }
    //        Destroy(gameObject);
    //    }
  //  }
    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
        foreach (Collider collider in colliders)
        {
            Rigidbody rigid = collider.GetComponent<Rigidbody>();
            if (rigid != null)
            {
                rigid.AddExplosionForce(ExplosionStrength, transform.position, ExplosionRadius, 0, ForceMode.Impulse);
            }
        }
        Destroy(gameObject);
    }
}
