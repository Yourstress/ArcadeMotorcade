using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrollImage : MonoBehaviour
{
    public float tileSize = 100;

    void Update()
    {
        RectTransform rt = (RectTransform)transform;

        Vector3 pos = rt.anchoredPosition;

        pos.y -= GameManager.instance.carSpeed * Time.deltaTime;

        // if we've scrolled past the screen, shift it up immediately
        while (pos.y <= 0)
            pos.y += tileSize;

        rt.anchoredPosition = pos;
    }
}