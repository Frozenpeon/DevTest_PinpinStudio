using System;
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
    public int actualForce { get; private set; }

    public int bonusForce { get; private set; }

    public static Action knockOut;
    public static Action<Expressions> showedExpression;
    public void ResetInstance(int minForce, int maxForce)   {
        SetForce(minForce, maxForce);
    }

    public void SetForce(int minForce, int maxForce) { 
        actualForce = UnityEngine.Random.Range(minForce, maxForce);
    }

    private int RealForce()
    {
        return actualForce + bonusForce;
    }

    private Expressions CalculateExpression(int weight) {
        if (weight <= RealForce() / 100 * percentagesEffortless)
            return Expressions.Effortless;
        else if (weight <= RealForce() / 100 * percentagesSlightStruggle)
            return Expressions.SlightStruggle;
        else if (weight <= RealForce() / 100 * percentagesPain)
            return Expressions.Pain;
        else if (weight <= RealForce())
            return Expressions.BigStruggle;
        else
            knockOut?.Invoke();
            return Expressions.KnockOut;
    }

    public void AddStrength(int addedForce)
    {
        bonusForce += addedForce;
    }

    public Expressions testWeight(int weight)  {
        Expressions e = CalculateExpression(weight);
        showedExpression?.Invoke(e);
        return e;
    }
}
