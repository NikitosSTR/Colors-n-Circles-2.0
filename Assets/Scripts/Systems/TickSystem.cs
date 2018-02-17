using Entitas;

namespace GameSystem.Systems
{
    public class TickSystem : IExecuteSystem, IInitializeSystem
    {
        private Contexts _contexts;

        public TickSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            _contexts.game.ReplaceTick(_contexts.input.tick.value + 1);
            _contexts.input.ReplaceTick(_contexts.input.tick.value + 1);
        }

        public void Initialize()
        {
            _contexts.game.ReplaceTick(0);
            _contexts.input.ReplaceTick(0);
        }
    }
}