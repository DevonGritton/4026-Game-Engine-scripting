using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public static bool lavaburn;
    // Start is called before the first frame update
    void Start()
    {
        lavaburn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lavaburn)
        {
            HealthScript.health -= 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lavaburn = true;
            Debug.Log(lavaburn);
        }
    }
}
