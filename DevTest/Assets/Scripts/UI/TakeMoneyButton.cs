using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMoneyButton : MonoBehaviour
{
    public GameObject winScreen;
    public void onClick()
    {
        winScreen.SetActive(true);
        winScreen.GetComponent<WinScreen>().SetUp();
    }
}
