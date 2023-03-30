using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Settings/Game Config", fileName = "GameConfig")]
[Game]
[Unique]
public class GameConfig : ScriptableObject
{
    [Header("PLAYER CONFIG")]
    public GameObject player;
    public GameObject projectile;
    public float projectileSpeed;
    public float moveSpeed;
    public float rotationSpeed;
    [Space(20)]
    [Header("ENEMY CONFIG")]
    public GameObject[] enemies;
    public float enemyMoveSpeed;
    public float enemyRotationSpeed;
}
