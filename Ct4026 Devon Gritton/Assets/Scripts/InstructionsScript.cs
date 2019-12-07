using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InstructionsScript : MonoBehaviour
{
    public GameObject instructions;
    // Start is called before the first frame update
    void Start()
    {
        instructions.SetActive(false);
    }
  
    private void OnTriggerEnter(Collider other)
    {
        instructions.SetActive(true); ;
    }
    private void OnTriggerExit(Collider other)
    {
        instructions.SetActive(false);
        Destroy(gameObject);
    }

}
