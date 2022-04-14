using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FireWork : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float upSpeed = 1.0f;
    private bool fire = false;
    
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            fire = true;
            particleSystem.Play();
        }

        if (fire)
        {
            transform.Translate(Vector3.up * upSpeed * Time.deltaTime);
        }
    }
}
