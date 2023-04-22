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
        this.GetComponent<Renderer>().material.color = new Color(
            Random.Range(0.6f, 1.0f),
            Random.Range(0.3f, 0.7f),
            Random.Range(0.0f, 0.4f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
