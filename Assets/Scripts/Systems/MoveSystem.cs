using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Analytics;

namespace GameSystem.Systems
{
    public class MoveSystem : ReactiveSystem<GameEntity>
    {
        private Contexts _contexts;

        public MoveSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.AnyOf(GameMatcher.Speed, GameMatcher.Rotation));
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasSpeed && entity.hasGameObject;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                var transform = entity.gameObject.value.transform;
                var speed = entity.speed.value;
                var movement = transform.up * speed * Time.deltaTime;
                entity.gameObject.value.transform.position += movement;
                
                entity.ReplaceSpeed(0.0f);
            }
        }
    }
}