using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractivElements : MonoBehaviour
{
    void Start()
    {
        InteractivityManager.disableInteractivesButtons += Disable;
        InteractivityManager.enableInteractivesButtons += Enable;
    }

    public virtual void Disable() {
      
    }
    public virtual void Enable() {
        
    }
}
