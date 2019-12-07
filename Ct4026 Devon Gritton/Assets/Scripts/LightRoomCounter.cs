using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoomCounter : MonoBehaviour
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
        if (counter >= 30)
        {
            Destroy(Latch1);
            Destroy(Latch2);
            Destroy(plates);
            Light.SetActive(true);
        }
    }
    void Increment()
    {
        counter += 1;

    }
    // Update is called once per frame
    void Update()
    {
        Prize();
    }
}
