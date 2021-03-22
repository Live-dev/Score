using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincameraa : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 dPos = target.position+offset;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, smoothSpeed);
        transform.position = sPos;
    }
}
