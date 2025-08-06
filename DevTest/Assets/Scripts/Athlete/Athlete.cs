using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Expressions {
    Effortless,
    SlightStruggle,
    Pain,
    BigStruggle,
    KnockOut,
}

public class Athlete
{
    public int percentagesEffortless = 30;
    public int percentagesSlightStruggle = 50;
    public int percentagesPain = 80;
    private int actualForce;

    public void ResetInstance(int minForce, int maxForce)   {
        SetForce(minForce, maxForce);
    }

    public void SetForce(int minForce, int maxForce) { 
        actualForce = Random.Range(minForce, maxForce);
    }


    public Expressions testWeight(int weight)  {
        if (weight <= actualForce/100 * percentagesEffortless)
            return Expressions.Effortless;
        else if (weight <= actualForce/100 * percentagesSlightStruggle)
            return Expressions.SlightStruggle;
        else if (weight <= actualForce/100 * percentagesPain)
            return Expressions.Pain;
        else if (weight <= actualForce)
            return Expressions.BigStruggle;
        else 
            return Expressions.KnockOut;

    }
}
