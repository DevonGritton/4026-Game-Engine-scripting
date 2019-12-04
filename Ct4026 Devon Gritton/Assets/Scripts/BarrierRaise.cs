using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierRaise : MonoBehaviour
{
    public GameObject BarrierObject;

    private bool barrierIsUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        barrierIsUp = !barrierIsUp;
        BarrierObject.GetComponent<Animator>().SetBool("barrierIsUp", barrierIsUp);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
