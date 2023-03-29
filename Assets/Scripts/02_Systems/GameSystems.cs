using Entitas;

public class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        Add(new HelloWorldSystem());
        Add(new InputSystem(contexts));
        Add(new InitializePlayerSystem(contexts));
        Add(new InstantiateViewSystem(contexts));
        Add(new RotatePlayerSystem(contexts));
        Add(new TranslatePlayerSystem(contexts));
    }
}
