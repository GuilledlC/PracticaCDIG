using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ScriptLanzador : MonoBehaviour
{
    public GameObject Proyectil;
    public int force;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject pajaroto = Instantiate(Proyectil, transform.position, new Quaternion());
            pajaroto.GetComponent<Rigidbody>().
                AddForce(transform.forward*force, ForceMode.Impulse);
            //pajaroto.GetComponent<Rigidbody>().
              //  AddForce();

        }
    }
}
