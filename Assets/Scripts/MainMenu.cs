using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void LoadIsland()
    {
        SceneManager.LoadScene("Island");
    }
    
    public void LoadBeach()
    {
        SceneManager.LoadScene("Beach");
    }
}
