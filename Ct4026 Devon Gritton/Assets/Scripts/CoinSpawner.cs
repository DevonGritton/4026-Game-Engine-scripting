using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
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
        lifespawn -= Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            DropMoney();
            timer = timerReset;
            timer -= Time.deltaTime;
        }
        if(lifespawn <= 0)
        {
            Destroy(gameObject);
        }
    }
    void DropMoney()
    {
        GameObject launch = Instantiate(Dropcoin, DropPoint.position, DropPoint.rotation * Quaternion.Euler(90f, 0f, 0f));
    }
}
