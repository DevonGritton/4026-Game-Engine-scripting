using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime *10, 0, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        ScoreScript.scoreValue += 1;
        Destroy (gameObject);
       // if (other.gameObject.CompareTag("Player"))
       // {
        //        other.GetComponent<ScoreScript>().scoreValue++;


         //   Destroy(gameObject); // destroys the game object when the player walks into it
        //}
    }
}