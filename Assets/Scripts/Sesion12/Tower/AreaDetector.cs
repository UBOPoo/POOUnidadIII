using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetector : MonoBehaviour
{
    public string targetTag;

    public delegate void FNotifyTarget(Collider other);
    public FNotifyTarget OnTargetEnter, OnTargetExit;


    private void OnTriggerEnter(Collider other)
    {
       
        if(other.CompareTag(targetTag))
        {
            Debug.Log("asd" + other);
            OnTargetEnter?.Invoke(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            OnTargetExit?.Invoke(other);
        }
    }
}
