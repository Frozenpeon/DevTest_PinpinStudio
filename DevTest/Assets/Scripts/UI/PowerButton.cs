using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerButton : MonoBehaviour
{
    public int addedForce;

    public void OnClick()
    {
        GameManager.Instance.IncreaseAthletePower(addedForce);
        GetComponent<Button>().interactable = false;
    }
}
