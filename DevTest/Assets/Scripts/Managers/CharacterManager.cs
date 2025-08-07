using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private GameObject character;

    public Vector3 spawnPosition = new Vector3(0, -25, 105);
    public Vector3 spawnScale = new Vector3(30, 30, 30);
    public Quaternion spawnRotation = Quaternion.Euler(0, 180, 0);

    public SO_CharacterList characterList;
    public AnimatorController controller;

    void Start()    {
        GameManager.startGame += Spawn;
        Athlete.showedExpression += PlayAnimation;
    }

    public void Spawn() {
        character = Instantiate(characterList.characters[Random.Range(0, characterList.characters.Count)], spawnPosition, spawnRotation);
        character.transform.localScale = spawnScale;
        character.GetComponent<Animator>().runtimeAnimatorController = controller; 
    }

    public void PlayAnimation(Expressions expression) {
        character.GetComponent<Animator>().Play(expression.ToString());
    }

    private void OnDestroy()
    {
        GameManager.startGame -= Spawn;
        Athlete.showedExpression -= PlayAnimation;
    }
}
