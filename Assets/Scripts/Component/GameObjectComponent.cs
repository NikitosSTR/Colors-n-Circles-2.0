using Entitas;
using UnityEngine;

namespace GameSystem.Component
{
    [Game]
    public class GameObjectComponent : IComponent
    {
        public GameObject value;
    }
}