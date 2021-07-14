using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private static MapManager instance;

    public static MapManager Instance { get { return instance; } }

    public GameObject towerPrefab;


    private void Awake()
    {
        instance = this;
    }


    void TryToPutTower()
    {
      Ray ray=      Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
         if(Physics.Raycast(ray,out hit))
        {
            if(hit.collider.CompareTag("Floor"))
            {
                Instantiate(towerPrefab, hit.point, Quaternion.identity);
            }
        }
    }


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TryToPutTower();
        }
    }

}
