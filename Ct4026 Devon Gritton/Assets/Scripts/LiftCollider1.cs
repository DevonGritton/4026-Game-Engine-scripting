﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftCollider1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = gameObject.transform;
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}

