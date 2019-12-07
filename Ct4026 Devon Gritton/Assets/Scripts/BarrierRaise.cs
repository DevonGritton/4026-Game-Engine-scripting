using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierRaise : MonoBehaviour
{
    public GameObject BarrierObject;
    public GameObject coinSpawning;
    public GameObject WinMessage;
    private bool barrierIsUp;
    // Start is called before the first frame update
    void Start()
    {
        coinSpawning.SetActive(false);
        WinMessage.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            barrierIsUp = !barrierIsUp;
            BarrierObject.GetComponent<Animator>().SetBool("barrierIsUp", barrierIsUp);
            DartTurret.firecountdown = 10000000000;
            coinSpawning.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        Destroy(gameObject);
            coinSpawning.SetActive(true);
            WinMessage.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
