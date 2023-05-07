using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGravedad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity.Set(-transform.up.x, -transform.up.y, -transform.up.z);
    }
}
