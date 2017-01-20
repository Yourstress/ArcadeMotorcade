
using UnityEngine;

[ExecuteInEditMode]
public class ZAligner : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = transform.localPosition;
        pos.z = pos.y * .001f;
        transform.localPosition = pos;
    }
}
