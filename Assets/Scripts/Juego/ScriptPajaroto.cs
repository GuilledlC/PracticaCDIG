using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPajaroto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 2);
    }
}
