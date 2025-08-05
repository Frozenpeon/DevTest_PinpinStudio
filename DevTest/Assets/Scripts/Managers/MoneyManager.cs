using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float startMoney = 1f;
    public float actualMoney { get; private set; }

    void Start()
    {
        actualMoney = startMoney;
    }

}
