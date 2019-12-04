using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartTurret : MonoBehaviour
{
    [SerializeField]
    public GameObject m_goDartPrefab;

    [SerializeField]
    private float m_fDartSpeed = 50.0f;

    public Transform firepoint;
    public float fireRate = 0.5f;
    public float firecountdown = 1f;
    public Transform target;
    public float range = 80f;
    public string targetTag = "Target";
    public Transform FaceToRotate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
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
            firecountdown = 1f;
        }
        if (target == null)
            return;
    }
    void UpdateTarget ()
    {
        GameObject[] Targets = GameObject.FindGameObjectsWithTag(targetTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestTarget = null;
        foreach (GameObject target in Targets)
        {
            float distancetoTarget = Vector3.Distance(transform.position, target.transform.position);
            if (distancetoTarget < shortestDistance)
            {
                shortestDistance = distancetoTarget;
                nearestTarget = target;
            }
        }

        if (nearestTarget != null && shortestDistance <= range)
        {
            target = nearestTarget.transform;
        }
        else
        {
            target = null;
        }


    }
    private void ShootBullet()
    {
        GameObject goSpawnedDart = Instantiate(m_goDartPrefab, firepoint.position, firepoint.rotation);
        //goSpawnedDart.transform.position = transform.position;
        //goSpawnedDart.transform.Translate(transform.forward);

        Rigidbody rbDartbody = goSpawnedDart.GetComponent<Rigidbody>();
        if (rbDartbody != null)
        {
            Vector3 dirToTarget =  target.position - rbDartbody.position;
            dirToTarget.Normalize();

            rbDartbody.velocity = dirToTarget * m_fDartSpeed;
        }
        Destroy(goSpawnedDart, 1.0f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.color = Color.blue;
    }
}
