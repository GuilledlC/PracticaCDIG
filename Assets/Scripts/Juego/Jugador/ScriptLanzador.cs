using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class ScriptLanzador : MonoBehaviour
{
    public GameObject Pajaroto;
    public GameObject Cerdaco;
    public int force;
    public AudioClip Shot;

    public void Disparar()
    {
        Vector3 pos = transform.position + Vector3.down;
        GameObject proyectil;
        if (Random.value > 0.95F)
            proyectil = Instantiate(Cerdaco, pos, new Quaternion());
        else
        {
            proyectil = Instantiate(Pajaroto, pos, new Quaternion());
            GetComponent<AudioSource>().PlayOneShot(Shot);
        }

        //Impulse
        proyectil.GetComponent<Rigidbody>().
            AddForce(transform.forward * force, ForceMode.Impulse);
            
        //Torque
        proyectil.GetComponent<Rigidbody>().
            AddTorque(transform.up * (Random.Range(-1, 1) * force));
        proyectil.GetComponent<Rigidbody>().
            AddTorque(transform.right * (Random.Range(-1, 1) * force));
        proyectil.GetComponent<Rigidbody>().
            AddTorque(transform.forward * (Random.Range(-1, 1) * force));
    }
}
