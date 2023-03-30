using Entitas;

public class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        Add(new HelloWorldSystem());
        
        Add(new InitializePlayerSystem(contexts));
        Add(new InitializeEnemiesSystem(contexts));
        
        Add(new InputSystem(contexts));
        Add(new ShootSystem(contexts));
        Add(new MoveSystem(contexts));
        
        Add(new MapEnemyLevelToResourceSystem(contexts));
        Add(new InstantiateViewSystem(contexts));
        
        Add(new RotatePlayerSystem(contexts));
        Add(new TranslatePlayerSystem(contexts));
    }
}
