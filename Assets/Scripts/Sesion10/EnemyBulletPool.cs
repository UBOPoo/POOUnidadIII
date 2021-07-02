using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletPool : MonoBehaviour
{
    private static EnemyBulletPool instance;
    public static EnemyBulletPool Instance { get { return instance; } }

    public List<GameObject> pool = new List<GameObject>();
    public GameObject prefab;
    public int initialSize = 10;

    private void Awake()
    {
        instance = this;
    }

    private void OnEnable()
    {
        InitializePool();

    }
    void InitializePool()
    {

        GameObject obj;
        for (int i = 0; i < initialSize; i++)
        {
            obj= Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);

        }

    }

    public GameObject GetPoolObject(Vector3 Position)
    {

        for (int i = 0; i < pool.Count; i++)
        {
            if(!pool[i].activeInHierarchy)
            {
                pool[i].SetActive(true);
                pool[i].transform.position = Position;
                return pool[i];

            }
        }

        GameObject obj = Instantiate(prefab, Position, Quaternion.identity);
        pool.Add(obj);
         
        return obj;
    }

}
