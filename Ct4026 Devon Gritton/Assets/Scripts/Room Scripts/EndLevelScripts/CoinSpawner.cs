using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour// This script is designed in order to spawn coins until a timer runs out
{
    [SerializeField]
    public GameObject Dropcoin;
    public float timer = 1.0f;
    public float timerReset = 1.0f;
    private float lifespawn = 10.0f;

    public Transform DropPoint;
    // Start is called before the first frame update
    void Start()
    {
        timer = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lifespawn -= Time.deltaTime;// the amount of time the spawners are active will tick down
        timer -= Time.deltaTime;// the rate at wich the next batch of coins is launched will tick down
        if (timer <= 0)
        {
            DropMoney();
            timer = timerReset;// The rate at wich coins will spawn will be reset
            timer -= Time.deltaTime;// the timer will continue to tick down
        }
        if(lifespawn <= 0)
        {
            Destroy(gameObject);// If the timer reaches 0 then the coin spawners will be destroyed
        }
    }
    void DropMoney()
    {
        GameObject launch = Instantiate(Dropcoin, DropPoint.position, DropPoint.rotation * Quaternion.Euler(90f, 0f, 0f));//Launches a coin at a given point with a 90* offset in the X axis
    }
}
