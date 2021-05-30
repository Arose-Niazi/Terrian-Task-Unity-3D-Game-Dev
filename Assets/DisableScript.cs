using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;

public class DisableScript : MonoBehaviour
{

    public bool sdisabled;
    // Update is called once per frame

    private Vector3 endPosition;
    private Rigidbody rb;
    private void Start()
    {
        endPosition = GameObject.Find("TeleportObject").transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            transform.position = endPosition;
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<ThirdPersonCharacter>().enabled = false;
            GetComponent<ThirdPersonUserControl>().enabled = false;
            sdisabled = true;
        }
    }
}
