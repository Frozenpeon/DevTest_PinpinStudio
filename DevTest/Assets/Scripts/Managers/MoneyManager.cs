using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float startMoney = 1f;
    public float actualMoney { get; private set; }

    public static Action moneyAdded;
    public static Action moneyRemoved;

    void Start() {
        actualMoney = startMoney;
    }

    public void addMoney(float amount)  {
        if(amount < 0) {
            Debug.LogWarning("Trying to add a negativ amount");
            return;
        }
        actualMoney += amount;
    }

    public void removeMoney(float amount)  {
        if (amount < 0)
        {
            Debug.LogWarning("Trying to remove a negativ amount");
            return;
        }
        actualMoney -= amount;
    }
}
