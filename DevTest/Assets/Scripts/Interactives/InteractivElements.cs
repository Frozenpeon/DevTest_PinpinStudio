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
        GetComponent<Collider>().enabled = false;
    }
    public virtual void Enable() {
        GetComponent<Collider>().enabled = true;
    }

    private void OnDestroy()
    {
        InteractivityManager.disableInteractivesButtons -= Disable;
        InteractivityManager.enableInteractivesButtons -= Enable;
    }
}
