using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScriptDropper : MonoBehaviour
{
    public GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Drop", 1, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 1, 0), 0.5f);
        if(Random.Range(0, 100) > 97)
            Drop();
    }

    private void Drop()
    {
        GameObject foo = Instantiate(objeto, transform.position, transform.rotation);
        foo.tag = "Untagged";
        foo.GetComponent<Rigidbody>().AddForce(transform.right * 10, ForceMode.Impulse);
        foo.GetComponent<Rigidbody>().
            AddTorque(transform.up * (Random.Range(-1, 1) * 250));
        foo.GetComponent<Rigidbody>().
            AddTorque(transform.right * (Random.Range(-1, 1) * 250));
        foo.GetComponent<Rigidbody>().
            AddTorque(transform.forward * (Random.Range(-1, 1) * 250));
    }
}
