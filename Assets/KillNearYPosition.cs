using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillNearYPosition : MonoBehaviour
{
    public float killAtApproxLocalPosition;
    void Update()
    {
        if (transform.localPosition.y < killAtApproxLocalPosition)
            Destroy(gameObject);
    }
}
