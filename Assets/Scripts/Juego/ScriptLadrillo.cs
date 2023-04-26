using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class ScriptLadrillo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AplicarColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LadrilloFantasma"))
            GetComponent<Renderer>().material.color = Color.blue;
    }

    private void AplicarColor()
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
}