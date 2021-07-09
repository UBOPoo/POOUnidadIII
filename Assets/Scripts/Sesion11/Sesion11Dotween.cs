using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Sesion11Dotween : MonoBehaviour
{
    public Vector3[] targetPositions;
    public LoopType loopType;
    public Ease ease=Ease.Linear;
    private void OnDrawGizmosSelected()
    {

       // Gizmos.DrawLine(transform.position, transform.position + (Vector3) targetPosition);
    }
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMove(transform.position + (Vector3)targetPosition, 2f).SetLoops(-1, loopType).SetEase(ease);
        transform.DOPath(targetPositions,2f).SetLoops(-1, loopType).SetEase(ease);
    }


   
}
