using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeightShower : MonoBehaviour
{
    public string prefix = "Actual weight : ";

    private TextMeshProUGUI textHolder;

    void Start()
    {
        textHolder = GetComponent<TextMeshProUGUI>();
        GameManager.newWeight += changeWeight;
        GameManager.startGame += startShowing;
    }

    public void startShowing()
    {
        gameObject.SetActive(true);
    }

    public void changeWeight(int weight)
    {
        textHolder.text = prefix + weight.ToString();
    }

    private void OnDestroy()
    {
        GameManager.newWeight -= changeWeight;
        GameManager.startGame -= startShowing;
    }
}

