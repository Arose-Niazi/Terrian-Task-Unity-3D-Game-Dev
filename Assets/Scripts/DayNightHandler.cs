using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DayNightHandler : MonoBehaviour
{
    public Material dayMaterial;
    public Material nightMaterial;

    public Transform sun;
    public Transform moon;
    
    public Light sunlight;
    public Light moonlight;
    
    private bool _sun = true;

    public Text infoText;
    public GameObject infoBox;

    public Light[] allLights;


    private void Start()
    {
        foreach (var l in allLights)
        {
            l.enabled = false;
        }
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
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(StartSwitch());
        }
    }
    
    IEnumerator StartSwitch()
    {
        if (_sun)
        {
            infoText.text = "Changing to Night...";
            infoBox.SetActive(true);
            while (Math.Abs(sun.localPosition.y + 500) > 10)
            {
                sun.RotateAround(Vector3.zero, Vector3.right, 30 * Time.deltaTime);
                sun.LookAt(Vector3.zero);
                moon.RotateAround(Vector3.zero, Vector3.right, 30 * Time.deltaTime);
                moon.LookAt(Vector3.zero);
                yield return new WaitForEndOfFrame();
            }
            RenderSettings.skybox = nightMaterial;
            RenderSettings.sun = moonlight;
        }
        else
        {
            infoText.text = "Changing to Day...";
            infoBox.SetActive(true);
            while (Math.Abs(sun.position.y - 500) > 10)
            {
                sun.RotateAround(Vector3.zero, Vector3.right, 30 * Time.deltaTime);
                sun.LookAt(Vector3.zero);
                moon.RotateAround(Vector3.zero, Vector3.right, 30 * Time.deltaTime);
                moon.LookAt(Vector3.zero);
                yield return new WaitForEndOfFrame();
            }
            RenderSettings.skybox = dayMaterial;
            RenderSettings.sun = sunlight;
        }
        foreach (var l in allLights)
        {
            l.enabled = _sun;
        }
        _sun = !_sun;
        infoBox.SetActive(false);
        yield return null;
    }
    
}
