﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour //This is a scri0pt for an alternative door method used a trigger option and continous animation
{
     Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();//On start assigns the animator component to the animator variable
    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("OpenDoor");//the open trigger in teh animation will be enabled
    }
    void OnTriggerExit(Collider other)
    {
        animator.enabled = true;// enables the animation to allow the door to close when the player exits the trigger
    }
    void pauseAnimationEvent()
    {
        animator.enabled = false;// will pause the animation when a puase is called in the animation loop
    }
}
