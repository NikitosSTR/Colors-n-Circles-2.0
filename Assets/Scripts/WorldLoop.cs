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
                    // init
                    .Add(new SpawnPlayerSystem(_contexts))
                    .Add(new TickSystem(_contexts))
                    
                    // controls
                    .Add(new MoveSystem(_contexts))
                    .Add(new InputControllSystem(_contexts))
                ;    
            
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void OnDestroy()
        {
            _systems.TearDown();
            _systems.DeactivateReactiveSystems();
            _systems.ClearReactiveSystems();
            _contexts.input.DestroyAllEntities();
            _contexts.game.DestroyAllEntities();
        }
    }
}
