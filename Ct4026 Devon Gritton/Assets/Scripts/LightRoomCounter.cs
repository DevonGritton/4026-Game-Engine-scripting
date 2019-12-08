using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoomCounter : MonoBehaviour // this script is here to count the amount of times a light colour is changed in the lightRoomScript file and then once it's reached a certain value destroy a set of gaemobjects
{
    public static int counter;
    public GameObject Latch1;
    public GameObject Latch2;
    public GameObject plates;
    public GameObject Light;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }
    void Prize()
    {
        if (counter >= 30)// when the counter reaches 30 and all lights have been turned green
        {
            Destroy(Latch1);//destroys teh following gameobjects
            Destroy(Latch2);
            Destroy(plates);
            Light.SetActive(true);//activates the assigned light variable 
        }
    }
    void Increment()
    {
        counter += 1;// used to store the amount of green lights there are in a scene 
    }
    // Update is called once per frame
    void Update()
    {
        Prize();// calls the prize function every frame
    }
}
