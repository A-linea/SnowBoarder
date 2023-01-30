using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.CompareTag("Ground"))
      {
          SceneManager.LoadScene(0);
      }
   }
}
