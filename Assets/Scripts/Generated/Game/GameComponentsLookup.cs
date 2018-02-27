//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentsLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int GameObject = 0;
    public const int Health = 1;
    public const int Player = 2;
    public const int Rotation = 3;
    public const int Speed = 4;

    public const int TotalComponents = 5;

    public static readonly string[] componentNames = {
        "GameObject",
        "Health",
        "Player",
        "Rotation",
        "Speed"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(GameSystem.Component.GameObjectComponent),
        typeof(GameSystem.Component.HealthComponent),
        typeof(GameSystem.Component.PlayerComponent),
        typeof(GameSystem.Component.RotationComponent),
        typeof(GameSystem.Component.SpeedComponent)
    };
}
