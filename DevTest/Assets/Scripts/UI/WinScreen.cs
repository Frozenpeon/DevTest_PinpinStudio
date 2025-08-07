using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void SetUp()
    {
        text.text = "Money : " + GaugeManager.wonMoney;
    }
}
