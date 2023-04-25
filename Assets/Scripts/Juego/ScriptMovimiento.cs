using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovimiento : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moverse();
    }
    
    private void Moverse()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * (speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * (speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * (speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * (speed * Time.deltaTime));
        if(Input.GetKey(KeyCode.LeftShift))
            transform.Translate(Vector3.down * (speed * Time.deltaTime));
    }
}
