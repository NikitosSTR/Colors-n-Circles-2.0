using Entitas;
using Entitas.CodeGeneration.Attributes;
using JetBrains.Annotations;
using UnityEngine;

namespace GameSystem.Component
{
    [Input, Unique]
    public class TickComponent : IComponent
    {
        public float value;
    }
}