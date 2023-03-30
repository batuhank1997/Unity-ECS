using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class ShootSystem : IExecuteSystem
{
    private Contexts _contexs;

    public ShootSystem(Contexts contexts)
    {
        _contexs = contexts;
    }
    
    public void Execute()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pew!");

            var entity = _contexs.game.CreateEntity();
            var speed = _contexs.game.gameConfig.value.projectileSpeed;
            entity.AddResource(_contexs.game.gameConfig.value.projectile);
            entity.AddInitialPosition(_contexs.game.playerEntity.view.value.transform.position);

            var forward = _contexs.game.playerEntity.view.value.transform.up;
            entity.AddAcceleration(forward * speed);
        }
    }
}
