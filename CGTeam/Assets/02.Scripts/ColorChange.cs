using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    Renderer Renderer;
    float n = 0.001f;

    private void Awake()
    {
        Renderer = gameObject.GetComponent<Renderer>();
        //Renderer.material.color = Color.HSVToRGB(0.00278f, 1, 1);
    }

    private void Update()
    {
        Renderer.material.color = Color.HSVToRGB(0.00278f + n, 1, 1);
    }



}
