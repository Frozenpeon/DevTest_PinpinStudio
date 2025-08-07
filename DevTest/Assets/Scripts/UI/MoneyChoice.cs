using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyChoice : MonoBehaviour
{
    public void TakeMoney()
    {

    }

    public void KeepBetting()
    {
        gameObject.SetActive(false);
        InteractivityManager.enableInteractivesButtons();
    }
}
