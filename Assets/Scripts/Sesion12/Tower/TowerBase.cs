using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    public AreaDetector areaDetector;

    public EnemyDefenceBase currentTarget;

    public GameObject projectilePrefab;
    public float firerate = 1f;

    private void OnDisable()
    {
        areaDetector.OnTargetEnter -= OnTargetAquired;
        areaDetector.OnTargetExit -= OnTargetLost;
    }
    private void OnEnable()
    {
        areaDetector.OnTargetEnter += OnTargetAquired;
        areaDetector.OnTargetExit += OnTargetLost;
    }
    void OnTargetAquired(Collider other)
    {
         
        currentTarget = other.GetComponent<EnemyDefenceBase>();

        StartCoroutine(BeginShooting());
    }
    void OnTargetLost(Collider other)
    {
     
        if(other.GetComponent<EnemyDefenceBase>()== currentTarget)
        {
            currentTarget = null;
            StopAllCoroutines();
        }
    }

    IEnumerator BeginShooting()
    {
        Vector3 targetDirection;
        GameObject projectile;
        while (currentTarget!=null)
        {
            targetDirection = (currentTarget.transform.position - transform.position).normalized;
            projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            projectile.GetComponent<ProjectileTower>().ShootTo(targetDirection);
            yield return new WaitForSeconds(firerate);

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
