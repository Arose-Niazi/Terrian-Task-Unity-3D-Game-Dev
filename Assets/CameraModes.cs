using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class CameraModes : MonoBehaviour
{
    public Material dayMaterial;

    public Material nightMaterial;

    public Light mainLight;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetKey(KeyCode.R))
        {
            RenderSettings.skybox = dayMaterial;
            mainLight.intensity = 1;
        }
        if (Input.GetKey(KeyCode.T))
        {
            RenderSettings.skybox = nightMaterial;
            mainLight.intensity = 0.1f;
        }
        if (Input.GetKey(KeyCode.Y))
        {
            RenderSettings.skybox = nightMaterial;
            mainLight.intensity = 0.3f;
        }
    }
    
}
