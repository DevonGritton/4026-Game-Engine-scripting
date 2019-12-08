using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartTurret : MonoBehaviour // The purpose of this script is to shoot a dart from a given point to a set destination
{
    [SerializeField]
    public GameObject m_goDartPrefab;

    [SerializeField]
    private float m_fDartSpeed = 50.0f;

    public Transform firepoint;
    public static float firecountdown;
    public Transform target;
    public float range = 80f;
    public string targetTag = "Target";
    public Transform FaceToRotate;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTarget();// will call the function at the start of the game to assign targets
        firecountdown = (Random.Range(1.0f, 5.0f));// sets a random value between 1 and 5 to each turret assigned withis script
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        Vector3 face = target.position - transform.position;
        Quaternion faceRotation = Quaternion.LookRotation(face);
        Vector3 rotate = faceRotation.eulerAngles;
        FaceToRotate.rotation = Quaternion.Euler(rotate.x, 0f, 0f);


        firecountdown -= Time.deltaTime;
        if (firecountdown <= 0)
        {
            ShootBullet();
            firecountdown = 1f;// this section of code will call the shoot function when the countdown reaches 0
        }
        if (target == null)// if there are no targets do nothing
            return;
        
    }
    void UpdateTarget ()
    {
        GameObject[] Targets = GameObject.FindGameObjectsWithTag(targetTag);//retrieves all gameobjects in the scene with the targetTag tag and assigns them to an array
        float shortestDistance = Mathf.Infinity;
        GameObject nearestTarget = null;
        foreach (GameObject target in Targets)//will loop through each target within the targets array
        {
            float distancetoTarget = Vector3.Distance(transform.position, target.transform.position);//Used to determine the distance between the target and the turret
            if (distancetoTarget < shortestDistance)
            {
                shortestDistance = distancetoTarget;
                nearestTarget = target;// Will assign a target automatically depending on which one is the nearest to the currently applied turret
            }
        }

        if (nearestTarget != null && shortestDistance <= range)// if a target has been acquired that is within range
        {
            target = nearestTarget.transform;// assigns the target to the direction in which the turret will shoot
        }
        else
        {
            target = null;//do nothing
        }


    }
    private void ShootBullet()
    {
        GameObject goSpawnedDart = Instantiate(m_goDartPrefab, firepoint.position, firepoint.rotation); //Launches the assigned dart prefab at the assigned position with the assigned rotational offset 

        Rigidbody rbDartbody = goSpawnedDart.GetComponent<Rigidbody>();//Retrieves the rigidbody for the assigned dart prefab
        if (rbDartbody != null)
        {
            Vector3 dirToTarget =  target.position - rbDartbody.position; // defines the direction in which the dart will be launched at
            dirToTarget.Normalize();// Ensure the prefab is shot straight and does not deviate

            rbDartbody.velocity = dirToTarget * m_fDartSpeed;// shoots the bullet at a set speed towards the defined speed
        }
        Destroy(goSpawnedDart, 1.0f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);// used to vizualize the range of the dart throwers
        Gizmos.color = Color.white;// colors the range in the color white
    }
}
