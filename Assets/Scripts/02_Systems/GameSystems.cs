using Entitas;

public class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        Add(new HelloWorldSystem());
        Add(new InitializePlayerSystem(contexts));
        Add(new InstantiateViewSystem(contexts));
    }
}
