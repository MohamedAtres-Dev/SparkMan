using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{ 
    [CreateAssetMenu(fileName = "PlayerStates", menuName = "Data/player States")]
    public class PlayerStates : ScriptableObject
    {
        [SerializeField] private float _currentMovementSpeed;
        [SerializeField] private float _maxMovementSpeed;
        [SerializeField] private float _minMovementSpeed;
        [SerializeField] private float _jumpSpeed;
        [SerializeField] private float _boosterSpeed;

        public float CurrentMovementSpeed { get => _currentMovementSpeed; set => _currentMovementSpeed = value; }
        public float JumpSpeed { get => _jumpSpeed; set => _jumpSpeed = value; }
        public float BoosterSpeed { get => _boosterSpeed; set => _boosterSpeed = value; }
        public float MaxMovementSpeed { get => _maxMovementSpeed; set => _maxMovementSpeed = value; }
        public float MinMovementSpeed { get => _minMovementSpeed; set => _minMovementSpeed = value; }
    }
}