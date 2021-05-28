using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{ 
    [CreateAssetMenu(fileName = "PlayerStates", menuName = "Data/player States")]
    public class PlayerStates : ScriptableObject
    {
        [SerializeField] private float _movementSpeed;
        [SerializeField] private float _jumpSpeed;
        [SerializeField] private float _boosterSpeed;

        public float MovementSpeed { get => _movementSpeed; set => _movementSpeed = value; }
        public float JumpSpeed { get => _jumpSpeed; set => _jumpSpeed = value; }
        public float BoosterSpeed { get => _boosterSpeed; set => _boosterSpeed = value; }
    }
}