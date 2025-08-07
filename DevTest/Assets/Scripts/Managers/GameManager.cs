using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


/// <summary>
/// Class to centralize informations and game state.
/// </summary>
public class GameManager : MonoBehaviour
{
    public int minPercentageOfActualForceForWeight, maxPercentageOfActualForceForWeight;

    public static GameManager Instance;

    public static Action startGame;
    public static Action newWeight;

    public Vector3 leftWeightPosition;
    public Vector3 rightWeightPosition;

    public GameObject weightPrefab;

    private GameObject leftWeight;
    private GameObject rightWeight;

    public TextMeshProUGUI leftText;
    public TextMeshProUGUI rightText;

    public int minForce, maxForce;

    private Athlete athlete = new Athlete();

    public int actualWeight { get; private set; }

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        athlete.SetForce(minForce, maxForce);
    }

    public void LaunchAGame()
    {
        leftWeight   = Instantiate(weightPrefab, leftWeightPosition, Quaternion.identity);
        rightWeight  = Instantiate(weightPrefab, rightWeightPosition, Quaternion.identity);
        actualWeight = 0;
        CalculateWeight();
        startGame?.Invoke();
    }

    private void CalculateWeight()
    {
        int leftWeightWeight = athlete.actualForce / 100 * UnityEngine.Random.Range(minPercentageOfActualForceForWeight, maxPercentageOfActualForceForWeight);
        int rightWeightWeight = leftWeightWeight + 20;
        leftWeight.GetComponent<IO_Weight>().setWeight(leftWeightWeight);
        rightWeight.GetComponent<IO_Weight>().setWeight(rightWeightWeight);
        leftText.text = leftWeightWeight.ToString();
        rightText.text = rightWeightWeight.ToString();
    }


    public void addWeight(int addedWeight)
    {
        actualWeight += addedWeight;
        athlete.testWeight(actualWeight);
    }


}
