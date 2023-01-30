using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] public float delay = 2f;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Invoke(nameof(ReloadScene),delay);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
