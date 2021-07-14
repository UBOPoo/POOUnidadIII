using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EnemyDefenceBase : MonoBehaviour
{
    Rigidbody rb;

    public float pathTime = 3f;
 
    public Vector3[] path;
    Vector3[] absolutePath;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        GenerateWorldPath();
    }

    void GenerateWorldPath()
    {
        absolutePath = new Vector3[path.Length];

        for (int i = 0; i < path.Length; i++)
        {
            absolutePath[i] = path[i] + transform.position;
        }

    }

    private void OnDrawGizmosSelected()
    {
        GenerateWorldPath();

        for (int i = 0; i < absolutePath.Length; i++)
        {
            Gizmos.DrawWireSphere(absolutePath[i], .2f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }
     
    private void OnEnable()
    {
        BeginFollowPath();
    }
    void BeginFollowPath()
    {
        rb.DOPath(absolutePath, pathTime);
    }
    
}
