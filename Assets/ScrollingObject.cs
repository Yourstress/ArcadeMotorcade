using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    void Update()
    {
        Vector3 pos = transform.localPosition;
        pos.y -= GameManager.instance.carSpeed * Time.deltaTime;
        transform.localPosition = pos;
    }
}
