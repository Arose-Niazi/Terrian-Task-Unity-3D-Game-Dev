using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    private GameObject playerCamera;

    public GameObject danceCam1;
    public GameObject danceCam2;
    
    public GameObject treesCam1;
    public GameObject treesCam2;

    public GameObject panda;
    public GameObject oldguy;
    public GameObject scarlet;
    public GameObject sophia;
    public GameObject zafina;
    public GameObject martha;

    public GameObject[] fireworks;
    
    void Start()
    {
        playerCamera = GameObject.Find("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) ||
            Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            danceCam1.SetActive(Input.GetKeyDown(KeyCode.Alpha1));
            danceCam2.SetActive(Input.GetKeyDown(KeyCode.Alpha2));
            treesCam1.SetActive(Input.GetKeyDown(KeyCode.Alpha3));
            treesCam2.SetActive(Input.GetKeyDown(KeyCode.Alpha4));
            playerCamera.SetActive(Input.GetKeyDown(KeyCode.Alpha0));
        }
        
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C) ||
            Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.N)  || Input.GetKeyDown(KeyCode.M))
        {
            panda.SetActive(Input.GetKeyDown(KeyCode.Z) || panda.GetComponent<DisableScript>().sdisabled);
            oldguy.SetActive(Input.GetKeyDown(KeyCode.X) || oldguy.GetComponent<DisableScript>().sdisabled);
            scarlet.SetActive(Input.GetKeyDown(KeyCode.C) || scarlet.GetComponent<DisableScript>().sdisabled);
            sophia.SetActive(Input.GetKeyDown(KeyCode.V) || sophia.GetComponent<DisableScript>().sdisabled);
            zafina.SetActive(Input.GetKeyDown(KeyCode.B) || zafina.GetComponent<DisableScript>().sdisabled);
            martha.SetActive(Input.GetKeyDown(KeyCode.N) || martha.GetComponent<DisableScript>().sdisabled);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(nameof(StartFireworks));
        }

        /*if (Input.GetKeyDown(KeyCode.Return))
        {
            panda.SetActive(panda.GetComponent<DisableScript>().sdisabled);
            oldguy.SetActive(oldguy.GetComponent<DisableScript>().sdisabled);
            scarlet.SetActive(scarlet.GetComponent<DisableScript>().sdisabled);
            sophia.SetActive(sophia.GetComponent<DisableScript>().sdisabled);
        }*/
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
