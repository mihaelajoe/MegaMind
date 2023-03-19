using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightController : MonoBehaviour
{
    public float initialIntensity = 2.0f;
    public float triggeredIntensity = 80.0f;

    private Light spotlightLight;
    private AudioSource audioSource;

    private void Start()
    {
        spotlightLight = GetComponent<Light>();
        spotlightLight.intensity = initialIntensity;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spotlightLight.intensity = triggeredIntensity;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spotlightLight.intensity = initialIntensity;
            audioSource.Stop();
        }
    }
}