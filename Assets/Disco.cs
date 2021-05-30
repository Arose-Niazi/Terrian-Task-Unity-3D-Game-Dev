using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour
{
    public Color[] colors;
    Light lt;
    
    public float duration = 1.0f;
    private int _lastCol;

    void Start()
    {
        lt = GetComponent<Light>();
        Invoke(nameof(ColorChange), duration);
    }

    void ColorChange()
    {
        // set light color
        lt.color = colors[++_lastCol % colors.Length];
        Invoke(nameof(ColorChange), duration);
    }
}
