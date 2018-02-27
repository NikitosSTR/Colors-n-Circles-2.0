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
            if (!_contexts.input.isPause)
            {
                _contexts.input.ReplaceTick(_contexts.input.tick.value + 1);
            }
        }

        public void Initialize()
        {
            _contexts.input.isPause = false;
            _contexts.input.ReplaceTick(0);
        }
    }
}