using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrap : MonoBehaviour
{
    GameObject Trap;
    GameObject Trap2;
    // Start is called before the first frame update
    void Start()
    {
        Trap = GameObject.FindWithTag("Latch");
        Trap2 = GameObject.FindWithTag("Latch2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Destroy(Trap);
            Destroy(Trap2);
        }
    }
}
