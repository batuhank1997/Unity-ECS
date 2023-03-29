using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Unique]
public class TranslatePlayerSystem : IExecuteSystem
{
    private Contexts _contexts;

    public TranslatePlayerSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        var input = _contexts.game.ınput.value;
        var playerTransform = _contexts.game.playerEntity.view.value.transform;
        var playerPosition = playerTransform.position;
        
        var pos = input * _contexts.game.gameConfig.value.moveSpeed * Time.deltaTime;
        
        playerPosition += pos;
        playerPosition.x = Mathf.Clamp(playerPosition.x, -2.5f, 2.5f);
        playerPosition.y = Mathf.Clamp(playerPosition.y, -3.5f, 3);
        
        playerTransform.position = playerPosition;
    }
}
