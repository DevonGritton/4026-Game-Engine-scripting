using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    bool coin = false;
    bool heart = false;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "Coin")
        {
            coin = true;
        }
        if (gameObject.tag == "Health")
        {
            heart = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (coin)
        {
            transform.Rotate(new Vector3(Time.deltaTime * 0, 0, 10));
        }
        if (heart)
        {
            transform.Rotate(new Vector3(Time.deltaTime * 0, 10, 0));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Coin" && other.gameObject.tag == "Player")
        {
            ScoreScript.scoreValue += 1;
            Destroy(gameObject);
        }
        if (gameObject.tag == "Health" && other.gameObject.tag =="Player")
        {
            HealthScript.health += 1;
            Destroy(gameObject);
        }
       // if (other.gameObject.CompareTag("Player"))
       // {
        //        other.GetComponent<ScoreScript>().scoreValue++;


         //   Destroy(gameObject); // destroys the game object when the player walks into it
        //}
    }
}