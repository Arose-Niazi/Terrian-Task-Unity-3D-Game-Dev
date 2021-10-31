using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;

public class DisableScript : MonoBehaviour
{

    public bool playerDisabled;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            InputHandler();
        }
    }
    
    void InputHandler()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<ThirdPersonCharacter>().enabled = playerDisabled;
            GetComponent<ThirdPersonUserControl>().enabled = playerDisabled;
            playerDisabled = !playerDisabled;
        }
    }
}
