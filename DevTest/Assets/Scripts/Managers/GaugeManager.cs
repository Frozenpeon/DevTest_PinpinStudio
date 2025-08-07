using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class GaugeManager : MonoBehaviour
{
    public Slider gauge;
    private float gaugeValue = 0;
    public static Action<int> checkPointReached;
    public List<int> checkpointValues = new List<int>();
    private int index = 0;
    private int goodGuess = 0;
    public static int wonMoney {  get; private set; }

    private void Start()
    {
        GameManager.newWeight += weightChecked;    
        wonMoney = 0;
    }

    public void weightChecked(int weight)
    {
        goodGuess += 1;
        gaugeValue += 0.11f;
        gauge.value = gaugeValue;
        if (goodGuess % 3 == 0)  {
            wonMoney += checkpointValues[index];
            checkPointReached?.Invoke(wonMoney);
            index++;
        }
    }

    private void OnDestroy()
    {
        GameManager.newWeight -= weightChecked;
    }
}
