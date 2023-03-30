using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class EnemyStayInBoundsSystem : IExecuteSystem
{
    private Contexts _contexts;
    private Camera _cam;
    private GameConfig _gameConfig;
    private IGroup<GameEntity> _group;

    public EnemyStayInBoundsSystem(Contexts contexts)
    {
        _contexts = contexts;
        _cam = Camera.main;
        _gameConfig = _contexts.game.gameConfig.value;
        _group = _contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Enemy, GameMatcher.View));
    }
    
    public bool IsInGameView(GameObject enemy)
    {
        if (enemy != null)
        {
            Vector3 viewportPoint = _cam.WorldToViewportPoint(enemy.transform.position);

            if (viewportPoint.x >= 0 && viewportPoint.x <= 1 && viewportPoint.y >= 0 && viewportPoint.y <= 1 && viewportPoint.z >= 0)
            {
                if (enemy.GetComponent<Renderer>().isVisible)
                    return true;
            }
        }

        return false;
    }

    public void Execute()
    {
        foreach (var entity in _group.GetEntities())
        {
            if (!IsInGameView(entity.view.value) || entity.view.value.transform.position.y < 2f)
            {
                entity.ReplaceAcceleration(-entity.acceleration.value.normalized * _gameConfig.enemyMoveSpeed);
            }
        }
    }
}
