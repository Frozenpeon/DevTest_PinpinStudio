using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterList", menuName = "Game/CharacterList")]

public class SO_CharacterList : ScriptableObject
{
    public List<GameObject> characters;
}
