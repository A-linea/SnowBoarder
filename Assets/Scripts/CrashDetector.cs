using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   [SerializeField] public float delay = 1f;
   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.CompareTag("Ground"))
      {
         Invoke(nameof(delayLoadingScene), delay );
      }
   }

   private void delayLoadingScene()
   {
      SceneManager.LoadScene(0);
   }
}
