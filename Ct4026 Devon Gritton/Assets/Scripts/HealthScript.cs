﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    Text HealthText;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    HealthText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = health.ToString();
    }
}
