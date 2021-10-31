using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCameras : MonoBehaviour
{
    public GameObject[] camerasToDisable;
    public void OnTriggerEnter(Collider other)
    {
        foreach (var cam in camerasToDisable)
        {
            cam.SetActive(false);
        }
    }
}
