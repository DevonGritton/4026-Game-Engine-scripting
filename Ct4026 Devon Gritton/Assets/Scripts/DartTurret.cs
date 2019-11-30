using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartTurret : MonoBehaviour
{
    [SerializeField]
    public GameObject m_goDartPrefab;

    [SerializeField]
    private float m_fDartSpeed = 100.0f;

    public Transform firepoint;
    public float fireRate = 0.5f;
    public float firecountdown = 1f;
    private Transform target;
    public float range = 80f;
    public string targetTag = "Target";
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
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


    }
    private void ShootBullet()
    {
        GameObject goSpawnedDart = Instantiate(m_goDartPrefab, firepoint.position, firepoint.rotation);
        goSpawnedDart.transform.position = transform.position;
        goSpawnedDart.transform.Translate(transform.forward);

        Rigidbody rbDartbody = goSpawnedDart.GetComponent<Rigidbody>();
        if (rbDartbody != null)
        {
            rbDartbody.velocity = transform.forward * m_fDartSpeed;
        }
        Destroy(goSpawnedDart, 1.0f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.color = Color.blue;
    }
}
