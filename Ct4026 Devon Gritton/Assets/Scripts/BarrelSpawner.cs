using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour

{
    [SerializeField]
    public GameObject DropBarrel;
    public float timer = 1.0f;
    public float timerReset = 1.0f;

    public Transform DropPoint;
    // Start is called before the first frame update
    void Start()
    {
        timer = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            LaunchBarrel();
            timer = timerReset;
            timer -= Time.deltaTime;
        }
    }
    void LaunchBarrel ()
    {
        GameObject launch = Instantiate(DropBarrel, DropPoint.position, DropPoint.rotation * Quaternion.Euler(90f, 0f, 0f));
    }
}
