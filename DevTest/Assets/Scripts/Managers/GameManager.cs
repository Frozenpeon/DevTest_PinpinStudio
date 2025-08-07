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
    public static Action<int> newWeight;

    public Vector3 leftWeightPosition;
    public Vector3 rightWeightPosition;

    public GameObject weightPrefab;

    private GameObject leftWeight;
    private GameObject rightWeight;

    public TextMeshProUGUI leftText;
    public TextMeshProUGUI rightText;

    public int minForce, maxForce;

    private Athlete athlete = new Athlete();

    private int betNumber;

    public GameObject moneyChoice;

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
        GaugeManager.checkPointReached += CheckPointReached;
    }

    public void LaunchAGame()
    {
        betNumber = 0;
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

    public void IncreaseAthletePower(int powerGain)
    {
        athlete.AddStrength(powerGain);
    }

    public void CheckPointReached(int money)
    {
        moneyChoice.SetActive(true);
        InteractivityManager.disableInteractivesButtons?.Invoke();
    }

    public void addWeight(int addedWeight)
    {
        betNumber += 1;
        actualWeight += addedWeight;
        if (athlete.testWeight(actualWeight) == Expressions.KnockOut)
        {
            lostGame();
            return;
        }
        CalculateWeight();
        newWeight?.Invoke(actualWeight);
       
    }

    private void lostGame()
    {

    }
}
