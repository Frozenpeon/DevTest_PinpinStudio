using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GainShower : MonoBehaviour
{
    public string prefix = "GAIN EN COURS : ";
    private TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        GaugeManager.checkPointReached += (int money) => { text.text = prefix + money.ToString();  };
    }




}
