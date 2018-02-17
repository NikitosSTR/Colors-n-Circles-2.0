using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace GameSystem.Systems
{
    public class InputControllSystem : IExecuteSystem
    {
        private Contexts _contexts;
        private IGroup<GameEntity> _players;
        
        public InputControllSystem(Contexts contexts)
        {
            _contexts = contexts;
            _players = _contexts.game.GetGroup(GameMatcher.Player);
        }

        public void Execute()
        {
            foreach (var entity in _players)
            {
                entity.AddSpeed(1.0f);
            }
        }
    }
}