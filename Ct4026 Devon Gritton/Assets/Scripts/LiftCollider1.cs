using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftCollider1 : MonoBehaviour// this script is intended to make objects travel with the lift at a smoother rate
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = gameObject.transform;// this code makes any object that enters the elevator a child object of it which allows for to move upwards and downards in smoother manner
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;// this will remove the object as a child of the elavator when they exit the trigger box
    }
}

