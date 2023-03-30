using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class HitEnemySystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexs;

    public HitEnemySystem(Contexts contetxs) : base(contetxs.game)
    {
        _contexs = contetxs;
    }
    
    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Collision);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasCollision;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            GameObject first = entity.collision.first;
            GameObject second = entity.collision.second;

            var firstEntity = _contexs.game.GetEntitiesWithView(first).SingleEntity();
            var secondEntity = _contexs.game.GetEntitiesWithView(second).SingleEntity();

            //HEALTH SYSTEM
            firstEntity.isDestroy = true;
            secondEntity.isDestroy = true;
        }
    }
}
