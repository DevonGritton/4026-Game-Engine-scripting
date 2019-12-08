using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBob : MonoBehaviour // this script is here to add a rotational element to the lightholder objects
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * 0, 1, 0));// This script is simply designed to add some motion to the light components for the holders to give the appearance of a power cell
    }
}
