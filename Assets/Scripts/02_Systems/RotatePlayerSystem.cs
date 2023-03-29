using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Unique]
public class RotatePlayerSystem : IExecuteSystem
{
    private Contexts _contexts;

    public RotatePlayerSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    public void Execute()
    {
        var input = _contexts.game.ınput.value.x;
        var playerTransform = _contexts.game.playerEntity.view.value.transform;
        var playerRotation =playerTransform.rotation.eulerAngles;

        if (Mathf.Abs(playerRotation.y) < 30)
            playerRotation.y += input * _contexts.game.gameConfig.value.rotationSpeed * Time.deltaTime;

        playerTransform.rotation = Quaternion.Euler(playerRotation);
    }
}
