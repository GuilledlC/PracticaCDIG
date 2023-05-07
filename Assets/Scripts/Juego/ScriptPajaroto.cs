using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class ScriptPajaroto : MonoBehaviour
{
    public TowerStats stats;
    
    public List<AudioClip> FlySounds;
    public AudioClip DeathSound;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        stats.PajarotoLanzado();
        
        audioSource = GetComponent<AudioSource>();
        
        Destroy(gameObject, 7);
        audioSource.PlayOneShot(FlySounds[Random.Range(0, FlySounds.Count)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(DeathSound, transform.position, 200);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 2);
    }
}
