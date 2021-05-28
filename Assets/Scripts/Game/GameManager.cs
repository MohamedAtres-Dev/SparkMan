using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] PlayerStates _playerStates;
        private GameState gameState;

        private void OnEnable()
        {
            PlayerCollision.onPlayerDied += OnPlayerDied;
        }

        private void OnDisable()
        {

            PlayerCollision.onPlayerDied -= OnPlayerDied;
        }
        private void Start()
        {
            gameState = GameState.START;
            _playerStates.CurrentMovementSpeed = _playerStates.MinMovementSpeed;
            InvokeRepeating("IncreaseSpeed", 2f, 3f);
        }

        private void IncreaseSpeed()
        {

            if (_playerStates.CurrentMovementSpeed >= _playerStates.MaxMovementSpeed)
            {
                _playerStates.CurrentMovementSpeed = _playerStates.MaxMovementSpeed;
            }
            else
            {
                _playerStates.CurrentMovementSpeed += 20f;
            }
        }

        private void OnPlayerDied()
        {
            gameState = GameState.End;
            CancelInvoke("IncreaseSpeed");
        }

        private void OnGameRestart()
        {

        }
    }

    public enum GameState
    {
        START,
        RESTART,
        End
    }
}