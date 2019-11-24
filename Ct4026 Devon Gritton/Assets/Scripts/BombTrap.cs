using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrap : MonoBehaviour
{
    public float ExplosionStrength = 30.0f;
    public float ExplosionRadius = 5.0f;
    public float BombTimer = 3.0f;
    float countdown;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "Player")
            {
            BombTimer -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (BombTimer <= 0)
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
}
