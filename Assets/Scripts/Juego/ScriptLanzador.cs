using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ScriptLanzador : MonoBehaviour
{
    public GameObject Proyectil;
    public int force;
    public AudioClip Shot;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        GameObject pajaroto = Instantiate(Proyectil, transform.position, new Quaternion());

        GetComponent<AudioSource>().PlayOneShot(Shot);
        
        //Impulse
        pajaroto.GetComponent<Rigidbody>().
            AddForce(transform.forward * force, ForceMode.Impulse);
            
        //Torque
        pajaroto.GetComponent<Rigidbody>().
            AddTorque(transform.up * (Random.Range(-1, 1) * force));
        pajaroto.GetComponent<Rigidbody>().
            AddTorque(transform.right * (Random.Range(-1, 1) * force));
        pajaroto.GetComponent<Rigidbody>().
            AddTorque(transform.forward * (Random.Range(-1, 1) * force));
    }
}
