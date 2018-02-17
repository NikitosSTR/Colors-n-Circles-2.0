using Entitas;
using GameSystem.Systems;
using UnityEngine;

namespace GameSystem
{
    public class WorldLoop : MonoBehaviour
    {

        private Entitas.Systems _systems;
        private Contexts _contexts;

        private void Awake()
        {
            _contexts = Contexts.sharedInstance;
        }

        private void Start()
        {
            _systems = new Feature("WorldLoop")
                .Add(new MoveSystem(_contexts));
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}
