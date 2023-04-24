using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScriptColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color =
            Color.Lerp(
            Color.gray, 
            Color.Lerp(
                Color.red,
                Color.yellow,
                Random.Range(0.25f, 0.70f)),
            Random.Range(0.2f, 0.6f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
