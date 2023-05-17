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

    public GameObject iconoP;
    public GameObject iconoC;

    public void Disparar()
    {
        Vector3 pos = transform.position + Vector3.down;
        GameObject proyectil;
        if (Random.value > 0.7F)
        {
            proyectil = Instantiate(Cerdaco, pos, new Quaternion());
            iconoP.SetActive(false);
            iconoC.SetActive(true);
        }
        else
        {
            proyectil = Instantiate(Pajaroto, pos, new Quaternion());
            iconoP.SetActive(true);
            iconoC.SetActive(false);
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
