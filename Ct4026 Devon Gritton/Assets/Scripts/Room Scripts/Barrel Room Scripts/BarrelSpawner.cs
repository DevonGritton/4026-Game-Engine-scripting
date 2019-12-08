using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour// this script is designed to spawn barrels at a set interval

{
    [SerializeField]
    public GameObject DropBarrel;
    public float timer = 1.0f;
    public float timerReset = 1.0f;

    public Transform DropPoint;
    // Start is called before the first frame update
    void Start()
    {
        timer = 1.0f;// sets the timer variable to 1 second
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; // reduces the timer in realtime every frame
        if (timer <= 0)// when the timer is less than or = to zero
        {
            LaunchBarrel();// calls the function to spawn the barrel
            timer = timerReset;// resets the timer to original value
            timer -= Time.deltaTime;// begins countind down the timer again
        }
    }
    void LaunchBarrel ()
    {
        GameObject launch = Instantiate(DropBarrel, DropPoint.position, DropPoint.rotation * Quaternion.Euler(90f, 0f, 0f));//spawns the assigned gameobject at its original rotation and position parameters with a 90 degree offset in teh x-axis so the barrel will roll on its rounded edge
    }
}
