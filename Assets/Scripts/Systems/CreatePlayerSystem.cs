using Entitas;

namespace Systems
{
    public sealed class CreatePlayerSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public CreatePlayerSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public void Initialize()
        {
            var e = _contexts.game.CreateEntity();
            e.AddHealth(100);
        }
    }
}