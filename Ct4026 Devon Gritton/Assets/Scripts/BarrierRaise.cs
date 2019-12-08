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
        //upon game start disables the 2 assigned game objects
        coinSpawning.SetActive(false);
        WinMessage.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)//called when something enters the trigger collider
    {
        if (other.gameObject.tag == "Player")// will only proceed with the code if the player enters the trigger collider
        {
            barrierIsUp = !barrierIsUp;
            BarrierObject.GetComponent<Animator>().SetBool("barrierIsUp", barrierIsUp);// Retrieves teh animator components setting the barrier is up bool to true tirggering the next stage of the animation to raise the barrier 
            DartTurret.firecountdown = 10000000000;// when the player enters the collider the turret fire delay will be increased to 10000000000 to avoid turrets firing when the barrier has been raised 
            coinSpawning.SetActive(true);// activates the coin spawners 
            WinMessage.SetActive(true);// displays the win message
        }
    }
    private void OnTriggerExit(Collider other)//called when something exits the trigger collider
    {
        if (other.gameObject.tag == "Player")// will only proceed with the code if the player exits the trigger collider
        {
        Destroy(gameObject);
            coinSpawning.SetActive(true);
        }
    }
}
