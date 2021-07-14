using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTower : MonoBehaviour
{
    Rigidbody rb;
    public float projectileSpeed = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void ShootTo(Vector3 Direction)
    {
        rb.velocity = Direction * projectileSpeed;
    }
}
