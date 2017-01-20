using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject personPrefab;
    public float spawnEveryMinSeconds = 1;
    public float spawnEveryMaxSeconds = 3;

    private float nextSpawnAt = 0;

    void Update()
    {
        if (Time.time >= nextSpawnAt)
        {
            GameObject person = Instantiate(personPrefab, transform, false);

            // move it to a random spot within the spawner
            person.transform.localPosition = GetRandomSpawnPosition();

            // determine when the next person will spawn
            nextSpawnAt = Time.time + Random.Range(spawnEveryMinSeconds, spawnEveryMaxSeconds);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        RectTransform rt = (RectTransform) transform;
        Vector3 pos = new Vector3(
            Random.Range(rt.rect.xMin, rt.rect.xMax),
            Random.Range(rt.rect.yMin, rt.rect.yMax),
            0);

        return pos;
    }
}
