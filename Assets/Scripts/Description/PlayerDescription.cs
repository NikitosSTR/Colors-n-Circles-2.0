using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameSystem.Description
{
    [CreateAssetMenu(menuName = "CnC/CharacterDescriptionCollection", fileName = "CharacterDescriptionCollection.asset")]
    public class PlayerDescription : ScriptableObject
    {
        public GameObject Player;
        
        public Image[] Skins;

        public float MoveSpeed;
        public float RotationSpeed;

        public WeaponDescription Weapons;
    }
}