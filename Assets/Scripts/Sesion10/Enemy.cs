using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShumpPool
{
    public class Enemy : MonoBehaviour
    {

        public int numberBullets360 = 10;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Shoot360", 0,0.5f);
        }

        void Shoot360()
        {

            float angleSeparation = 360f / numberBullets360;
            Vector2 direction;

            for (int i = 0; i < numberBullets360; i++)
            {
                GameObject bullet = EnemyBulletPool.Instance.GetPoolObject(transform.position);

                direction = RotateVector(Vector2.down, Mathf.Deg2Rad* angleSeparation*i);
                bullet.GetComponent<Bullet>().ShootTo(direction);
            }

        }


        Vector2 RotateVector(Vector2 OriginalVector,float angle)
        {
            Vector2 rotated = Vector2.zero;
            rotated.x = (OriginalVector.x * Mathf.Cos(angle)) - (OriginalVector.y * Mathf.Sin(angle));
            rotated.y = (OriginalVector.x * Mathf.Sin(angle)) + (OriginalVector.y * Mathf.Cos(angle));

            return rotated;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player"))
            {
                CancelInvoke();
            }

        }
        void ShootBullet()
        {

            GameObject bullet = EnemyBulletPool.Instance.GetPoolObject(transform.position);

            //   bullet.GetComponent<Bullet>().ShootTo(transform.up * -1);
            bullet.GetComponent<Bullet>().ShootTo(Vector2.down);
        }
        
    }

}
