using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HelicopterExplosion : MonoBehaviour
{
    private ParticleSystem particle;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        StartCoroutine(Explosion());
        
    }

    private IEnumerator Explosion()
    {
        if (sekiller.patlasinmiPatlamasinmi == 1)
        {
            
            particle.Play();
            spriteRenderer.enabled = false;
            yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
            FindObjectOfType<OyunYoonetimi>().GameOver();
            

        }
    }
}
