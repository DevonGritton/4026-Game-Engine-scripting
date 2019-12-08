using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InstructionsScript : MonoBehaviour
{
    public GameObject instructions;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")// this is used to make sure that only the player can trigger the pop up prompt
        {
            instructions.SetActive(true);// enables the assigned instructions object     
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")// determines that only when the player can have the prompt removed
        {
            instructions.SetActive(false);// when the player exits the trigger the instructions will be disabled and their gameobject will be destroyed to avoid the player having unintentional pop ups
        }
    }
}
