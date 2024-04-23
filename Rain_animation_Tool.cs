using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain_animation_Tool : MonoBehaviour
{
    [SerializeField] AudioSource rainSound;
    [SerializeField] ParticleSystem rainParticleSystem; // Reference to the Particle System controlling rain
    private bool isRaining = false; // Flag to track if it's currently raining

    // Start is called before the first frame update
    void Start()
    {
        // Initialize rainParticleSystem if not set in the Inspector
        if (rainParticleSystem == null)
        {
            rainParticleSystem = GetComponent<ParticleSystem>();
        }

        // Start raining when the script starts 
        if (isRaining)
        {
            StartRaining();
        }
    }

    // Function to start raining
    public void StartRaining()
    {
        // Enable the Particle System
        if (rainParticleSystem != null)
        {
            rainParticleSystem.Play();
            rainSound.Play();
            isRaining = true;
        }
    }
    private void OnMouseDown()
    {
        ToggleRain();
    }

    // Function to stop raining
    public void StopRaining()
    {
        // Disable the Particle System
        if (rainParticleSystem != null)
        {
            rainParticleSystem.Stop();
            rainSound.Stop();
            isRaining = false;
        }
    }

    // Function to toggle rain on and off
    public void ToggleRain()
    {
        if (isRaining)
        {
            StopRaining();
        }
        else
        {
            StartRaining();
        }
    }
}
