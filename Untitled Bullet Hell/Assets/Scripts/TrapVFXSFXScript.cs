using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapVFXSFXScript : MonoBehaviour
{
    private AudioSource sound;
    private ParticleSystem particles;

    private void Start()
    {
        sound = this.gameObject.GetComponent<AudioSource>();
        particles = this.gameObject.GetComponent<ParticleSystem>();
    }

    public void playFX()
    {
        sound.Play();
        particles.Play();
    }
}
