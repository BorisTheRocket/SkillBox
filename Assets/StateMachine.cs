using System.Collections;
using System.Collections.Generic;  
using UnityEngine;

public class StateMachine : MonoBehaviour
{
   [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    private GameObject  currentScreen;
    private void Start()
   {
    firstScreen.SetActive(true);
    currentScreen = firstScreen;
   }
}
