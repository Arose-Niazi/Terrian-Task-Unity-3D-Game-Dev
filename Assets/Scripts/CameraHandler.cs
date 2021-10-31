using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    

    public GameObject danceCam1;
    public GameObject danceCam2;
    
    public GameObject treesCam1;
    public GameObject treesCam2;
    
    public GameObject[] fireworks;

    private Vector3 _oldCamPos;
    private Quaternion _oldCamRot;
    
    private GameObject _playerCamera;
    void Start()
    {
        _playerCamera = GameObject.Find("MainCamera");
    }
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            InputHandler();
        }
    }

    void InputHandler()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) ||
            Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            danceCam1.SetActive(Input.GetKeyDown(KeyCode.Alpha1));
            danceCam2.SetActive(Input.GetKeyDown(KeyCode.Alpha2));
            treesCam1.SetActive(Input.GetKeyDown(KeyCode.Alpha3));
            treesCam2.SetActive(Input.GetKeyDown(KeyCode.Alpha4));
            _playerCamera.SetActive(Input.GetKeyDown(KeyCode.Alpha0));
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(nameof(StartFireworks));
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            var pcam = _playerCamera.GetComponent<fly>();
            if (pcam.enabled)
            {
                _playerCamera.transform.position = _oldCamPos;
                _playerCamera.transform.rotation = _oldCamRot;
                pcam.enabled = false;
            }
            else
            {
                _oldCamPos = _playerCamera.transform.position;
                _oldCamRot = _playerCamera.transform.rotation;
                pcam.enabled = true;
                
            }
                
        }
    }
    
    IEnumerator StartFireworks()
    {
        var loc = GameObject.Find("FireworksLoc").transform;
        foreach (var f in fireworks)
        {
            Instantiate(f, loc.position, loc.localRotation);
            yield return new WaitForSeconds(2f);
        }

        var fw = GameObject.FindGameObjectsWithTag("Fireworks");
        foreach (var f in fw)
        {
            Destroy(f);
        }

    }
}
