using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShootTo(Vector2 Direction)
    {
        GetComponent<Rigidbody2D>().velocity = Direction * bulletSpeed;
    }

    private void OnBecameInvisible()
    {
       // Destroy(gameObject);
      gameObject.SetActive(false);
    }
}
