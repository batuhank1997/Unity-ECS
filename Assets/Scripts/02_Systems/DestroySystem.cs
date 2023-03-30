using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public class DestroySystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexs;

    public DestroySystem(Contexts contetxs) : base(contetxs.game)
    {
        _contexs = contetxs;
    }
    
    public DestroySystem(IContext<GameEntity> context) : base(context)
    {
    }

    public DestroySystem(ICollector<GameEntity> collector) : base(collector)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Destroy);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isDestroy;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            if (entity.hasView)
            {
                var view = entity.view.value;
                view.Unlink();
                Object.Destroy(view);
            }
            
            entity.Destroy();
        }
    }
}
