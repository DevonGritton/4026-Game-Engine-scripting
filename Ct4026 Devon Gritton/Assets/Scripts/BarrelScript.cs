using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    public GameObject Effect;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5.0f;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Enviroment"))
        {
            Instantiate(Effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (other.collider.CompareTag("Player"))
        {
            Instantiate(Effect, transform.position, transform.rotation);
            HealthScript.health -= 2;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HealthScript.health -= 2;
        }
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(Effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
