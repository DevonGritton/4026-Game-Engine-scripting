using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InstructionsScript : MonoBehaviour
{
    public GameObject instructions;
    // Start is called before the first frame update
    void Start()
    {
        instructions.SetActive(false);// disables instructions prompt
    }
  
    private void OnTriggerEnter(Collider other)
    {
        instructions.SetActive(true);// enables the assigned instructions object
    }
    private void OnTriggerExit(Collider other)
    {
        instructions.SetActive(false);// when the player exits the trigger the instructions will be disabled and their gameobject will be destroyed to avoid the player having unintentional pop ups
        Destroy(gameObject);
    }

}
