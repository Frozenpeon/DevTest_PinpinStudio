using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IO_Weight : InteractibleObject
{
    public int weight;


    /// <summary>
    /// We can easily add logiq here for the sounds or squash and strech
    /// </summary>
    public override void Interact()
    {
        GameManager.Instance.addWeight(weight);
    }

    public void setWeight(int weight)
    {
        this.weight = weight;
    }
}
