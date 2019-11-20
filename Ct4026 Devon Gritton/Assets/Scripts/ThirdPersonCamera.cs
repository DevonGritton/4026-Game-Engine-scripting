using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    //This section defnes the variables for the code
    public float MouseSensitivity = 10;
    public float DistanceFromTarget = 2;
    public Transform target;
    // called as a vector2 as there are only 2 directions this method concerns up/down
    public Vector2 verticalMinMax = new Vector2(-40, 85);

    public float RotationSmoothTime = 0.10f;
    Vector3 RotationSmoothVelocity;
    Vector3 CurrentRotation;

    float Horizontal;
    float Vertical;
    // Start is called before the first frame update
    void Start()
    {
       //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    //Late update is called after the other update positions to ensure the targets positions has been set
    void LateUpdate()
    {
        //Allows for the movement of the camera by moving the mouse in various directions
        Horizontal += Input.GetAxis("Mouse X") * MouseSensitivity;
        Vertical -= Input.GetAxis("Mouse Y") * MouseSensitivity;
        //limits the camera rotation so it cant be looped round the player multiple times to see through objects and the map
        Vertical = Mathf.Clamp(Vertical, verticalMinMax.x, verticalMinMax.y);

        CurrentRotation = Vector3.SmoothDamp(CurrentRotation, new Vector3(Vertical, Horizontal), ref RotationSmoothVelocity, RotationSmoothTime);

        //Vector3 TargetRotation = new Vector3(Vertical, Horizontal);
        transform.eulerAngles = CurrentRotation;
        //makes the camera rotate around the targeted position which will be located on the character
        transform.position = target.position - transform.forward * DistanceFromTarget;
    }
}
