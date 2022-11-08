using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class WinCondition : MonoBehaviour
{
    public UnityEvent winCondition;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BottleOfWater"))
        {
            if (winCondition != null)
                winCondition.Invoke(); 
            
        }
    }
}
