using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Class to centralize informations and game state.
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    public void LaunchAGame()
    {
        
    }


}
