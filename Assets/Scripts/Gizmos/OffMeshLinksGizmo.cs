using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffMeshLinksGizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, 0.2f);
    }
}
