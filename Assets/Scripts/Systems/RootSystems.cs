namespace Systems
{
    public sealed class RootSystems : Feature
    {
        public RootSystems(Contexts contexts)
        {
            Add(new LogHealthSystem(contexts));
            Add(new CreatePlayerSystem(contexts));
        }
    }
}