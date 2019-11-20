using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
     Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Open");
    }
    void OnTriggerExit(Collider other)
    {
        animator.enabled = true;
    }
    void pauseAnimationEvent()
    {
        animator.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
