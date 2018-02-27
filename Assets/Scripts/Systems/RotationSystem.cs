using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace GameSystem.Systems
{
    public class RotationSystem : ReactiveSystem<GameEntity>
    {
        private Contexts _contexts;
        
        public RotationSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }
        
        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Rotation);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasGameObject;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.gameObject.value.transform.Rotate(Vector3.forward * entity.rotation.value);
                entity.ReplaceRotation(0.0f);
            }
        }
    }
}