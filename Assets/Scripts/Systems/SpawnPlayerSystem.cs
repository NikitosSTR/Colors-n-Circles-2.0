using Entitas;
using UnityEngine;

namespace GameSystem.Systems
{
    public class SpawnPlayerSystem : IInitializeSystem
    {
        private Contexts _contexts;

        public SpawnPlayerSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 0.5F, 0);
            var spawnEntity = _contexts.game.CreateEntity();
            spawnEntity.AddGameObject(cube);
            spawnEntity.isPlayer = true;
            spawnEntity.AddSpeed(0.0f);
            spawnEntity.AddRotation(0.0f);
        }
    }
}