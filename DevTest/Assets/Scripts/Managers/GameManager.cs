using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Class to centralize informations and game state.
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static Action startGame;
    public static Action newWeight;
    
    public int minForce, maxForce;

    private Athlete athlete = new Athlete();

    public int actualWeight {  get; private set; }

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
        actualWeight = 0;
        startGame?.Invoke();
    }

    public void addWeight(int addedWeight)
    {
        actualWeight += addedWeight;
        athlete.testWeight(actualWeight);
    }


}
