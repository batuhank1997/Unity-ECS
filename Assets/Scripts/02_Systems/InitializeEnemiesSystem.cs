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
        for (int i = 0; i < 10; i++)
        {
            var entity = _contexs.game.CreateEntity();
            
            entity.AddEnemy(3);
            entity.AddInitialPosition(new Vector3(Random.Range(-3f, 3f), Random.Range(2, 6f), 0f));
        }
    }
}
