using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class InitializeEnemiesSystem : IInitializeSystem
{
    private Contexts _contexs;

    public InitializeEnemiesSystem(Contexts contexts)
    {
        _contexs = contexts;
    }

    public void Initialize()
    {
        var gameConfig = _contexs.game.gameConfig.value;
        
        for (int i = 0; i < 10; i++)
        {
            var entity = _contexs.game.CreateEntity();
            
            entity.AddEnemy(3);
            entity.AddInitialPosition(new Vector3(Random.Range(-3f, 3f), Random.Range(2, 6f), 0f));
            entity.AddAcceleration(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)).normalized * gameConfig.enemyMoveSpeed);
        }
    }
}
