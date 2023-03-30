using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

[Game]
public class MoveSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _group;

    public MoveSystem(Contexts contexts)
    {
        _contexts = contexts;
        _group = _contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Acceleration, GameMatcher.View));
    }

    public void Execute()
    {
        foreach (var entity in _group.GetEntities())
        {
            var view = entity.view.value;
            var acc = entity.acceleration.value;

            var pos = view.transform.position;
            pos += acc * Time.deltaTime;

            view.transform.position = pos;
        }
    }
}
