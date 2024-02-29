using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pasos : MonoBehaviour
{
    public AudioClip pasos; // Clip de audio para el sonido de pasos
    public float stepInterval = 0.5f; // Intervalo entre pasos en segundos
    public float volume = 1.0f; // Volumen del sonido de pasos
    public float pitch = 1.0f; // Variable pública para controlar la velocidad del audio
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pasos;
        audioSource.volume = volume;
        audioSource.loop = true; // Activa el bucle del sonido
        audioSource.pitch = pitch;
    }

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    public void SetPitch(float newPitch)
    {
        pitch = newPitch;
        audioSource.pitch = pitch;
    }
}



















