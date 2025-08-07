using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractivButton : InteractivElements
{
    public override void Disable()  {
        GetComponent<Button>().interactable = false;
    }
    public override void Enable()   {
        GetComponent<Button>().interactable = true;
    }
}
