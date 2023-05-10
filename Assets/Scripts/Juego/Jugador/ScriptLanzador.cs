using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ScriptLanzador : MonoBehaviour
{
    public GameObject Proyectil;
    public int force;
    public AudioClip Shot;

    public void Disparar()
    {
        Vector3 pos = transform.position + Vector3.down;
        GameObject pajaroto = Instantiate(Proyectil, pos, new Quaternion());

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
