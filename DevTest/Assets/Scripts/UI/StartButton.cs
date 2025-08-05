using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{


    public void OnClick()
    {
        GameManager.Instance.LaunchAGame();
        GetComponent<Button>().interactable = false;
    }
}
