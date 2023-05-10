using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCrawler : MonoBehaviour
{
    public float velocidad = 20f;
    void Update()
    {
        transform.Translate(Camera.main.transform.up * (velocidad * Time.deltaTime));
    }
}
