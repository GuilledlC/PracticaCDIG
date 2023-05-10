using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class ScriptLadrillo : MonoBehaviour
{
    public TowerStats stats;
    private bool fuera = false;

    private bool hasEnteredOnce = false;
    
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
        if (!hasEnteredOnce)
        {
            hasEnteredOnce = true;
            return;
        }
            
            
        if (other.gameObject.CompareTag("Trigger") && !fuera)
        {
            //print("adios");
            stats.LadrilloDestruido();
            fuera = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tocado"))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            gameObject.tag = "Tocado";
        }

    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Tocado"))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            gameObject.tag = "Tocado";
        }
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
