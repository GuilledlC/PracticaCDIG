using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class ScriptPajarotoCerdaco : MonoBehaviour
{
    public TowerStats stats;
    
    public List<AudioClip> FlySounds;
    public AudioClip DeathSound;
    public int deathTime = 7;
    
    private AudioSource audioSource;
    private bool muted = false;

    // Start is called before the first frame update
    void Start()
    {
        stats.PajarotoLanzado();
        
        audioSource = GetComponent<AudioSource>();
        
        Destroy(gameObject, deathTime);
        audioSource.PlayOneShot(FlySounds[Random.Range(0, FlySounds.Count)]);
    }

    private void Update()
    {
        if (audioSource.mute == true)
            muted = true;
    }

    private void OnDestroy()
    {
        if(!muted)
            AudioSource.PlayClipAtPoint(DeathSound, transform.position, 200);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 2);
    }
}
