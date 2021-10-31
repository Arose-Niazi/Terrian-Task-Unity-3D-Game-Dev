using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunFollow : MonoBehaviour
{
    public Transform lookAt;
    void Update()
    {
        transform.LookAt(lookAt.position);
    }
}
