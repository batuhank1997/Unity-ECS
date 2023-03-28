using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Settings/Game Config", fileName = "GameConfig")]
[Game]
[Unique]
public class GameConfig : ScriptableObject
{
    public GameObject player;
}
