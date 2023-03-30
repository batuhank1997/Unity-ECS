using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class MapEnemyLevelToResourceSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexs;

    public MapEnemyLevelToResourceSystem(Contexts contetxs) : base(contetxs.game)
    {
        _contexs = contetxs;
    }
    
    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Enemy);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasEnemy;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.AddResource(MapEnemyLevelToResource());
        }
    }

    private GameObject MapEnemyLevelToResource()
    {
        var enemies = _contexs.game.gameConfig.value.enemies;
        return (enemies[Random.Range(0, enemies.Length)]);
    }
}
