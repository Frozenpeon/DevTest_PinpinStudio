using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public Vector3 spawnPosition = new Vector3(0, -25, 105);
    public Vector3 spawnScale = new Vector3(30, 30, 30);
    public Quaternion spawnRotation = Quaternion.Euler(0, 180, 0);
    public SO_CharacterList characterList;
    public AnimatorController controller;

    void Start()    {
        GameManager.startGame += Spawn;
    }

    public void Spawn()
    {
        GameObject go = Instantiate(characterList.characters[Random.Range(0, characterList.characters.Count)], spawnPosition, spawnRotation);
        go.transform.localScale = spawnScale;
        go.GetComponent<Animator>().runtimeAnimatorController = controller; 
    }
}
