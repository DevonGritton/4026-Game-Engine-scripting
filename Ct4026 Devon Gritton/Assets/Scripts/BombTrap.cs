using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrap : MonoBehaviour
{
    public float ExplosionStrength = 30;
    public float ExplosionRadius = 5;
    public float BombTimer = 3;

    private bool bombon = false;

    // Update is called once per frame
    void Update()
    {
        if (bombon)
        {
            BombTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        bombon = true;
        

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
