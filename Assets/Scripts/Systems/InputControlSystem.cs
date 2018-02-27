using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace GameSystem.Systems
{
    public class InputControlSystem : ReactiveSystem<InputEntity>
    {
        private Contexts _contexts;
        private IGroup<GameEntity> _players;


        public InputControlSystem(Contexts contexts) : base(contexts.input)
        {
            _contexts = contexts;
            _players = _contexts.game.GetGroup(GameMatcher.Player);
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.Tick);
        }

        protected override bool Filter(InputEntity entity)
        {
            return true;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                foreach (var entity in _players)
                {
                    entity.ReplaceSpeed(entity.speed.value + 1.0f);
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                foreach (var entity in _players)
                {
                    entity.ReplaceSpeed(entity.speed.value - 1.0f);
                }
            }
            
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                foreach (var entity in _players)
                {
                    entity.ReplaceRotation(entity.rotation.value + 1f);
                }   
            }
            
            if (Input.GetKey(KeyCode.RightArrow))
            {
                foreach (var entity in _players)
                {
                    entity.ReplaceRotation(entity.rotation.value - 1f);
                }   
            }
            
            
        }
    }
}