using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibujarTrayectoria : MonoBehaviour
{

    public Transform desde;
    public Transform hasta;

    private void OnDrawGizmosSelected()
    {
        if (desde!=null&&hasta!=null)
        {
            Gizmos.color=Color.magenta;
            Gizmos.DrawLine(desde.position, hasta.position);
            Gizmos.DrawSphere(desde.position, 0.15f);
            Gizmos.DrawSphere(desde.position, 0.15f);

        }
    }

}
