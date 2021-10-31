using System;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cameraToSwitch;
    public void OnTriggerEnter(Collider other)
    {
       cameraToSwitch.SetActive(true);
    }
}
