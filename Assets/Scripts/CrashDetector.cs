using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] public float delay = 1f;
    [SerializeField] ParticleSystem crashEffect;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ground"))
        {
            crashEffect.Play();
            Invoke(nameof(DelayLoadingScene), delay);
        }
    }

    private void DelayLoadingScene()
    {
        SceneManager.LoadScene(0);
    }
}