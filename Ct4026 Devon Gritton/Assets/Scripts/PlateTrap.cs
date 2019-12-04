using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrap : MonoBehaviour
{
    public GameObject Trap;
    public GameObject Trap2;
    public GameObject Coins1;
    // Start is called before the first frame update
    void Start()
    {

        Coins1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Coins1.SetActive(true);
            Destroy(Trap);
            Destroy(Trap2);
        }
    }
}
