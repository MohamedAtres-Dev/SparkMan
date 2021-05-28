using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {

        #region Fields
        [SerializeField] PlayerStates _playerStates;


        [NonSerialized] public Rigidbody2D rb;
        [NonSerialized] public bool isSwipingRight;
        [NonSerialized] public bool isSwipingLeft;
        [NonSerialized] public bool isSwipingUp;
        [NonSerialized] public bool isSwipingDown;
        #endregion
        #region Monobehaviour

        private void OnEnable()
        {
            PlayerInputManager.onSwipeUp += OnSwipeUp;
            PlayerInputManager.onSwipeDown += OnSwipeDown;
            PlayerInputManager.onSwipeLeft += OnSwipeLeft;
            PlayerInputManager.onSwipeRight += OnSwipeRight;
        }

        private void OnDisable()
        {
            PlayerInputManager.onSwipeUp -= OnSwipeUp;
            PlayerInputManager.onSwipeDown -= OnSwipeDown;
            PlayerInputManager.onSwipeLeft -= OnSwipeLeft;
            PlayerInputManager.onSwipeRight -= OnSwipeRight;
        }
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {
            rb.velocity = (new Vector2(_playerStates.MovementSpeed * Time.deltaTime , rb.velocity.y));

            if (isSwipingUp)
            {
                rb.velocity = (new Vector2(rb.velocity.x, _playerStates.JumpSpeed * Time.fixedDeltaTime));
                Debug.Log("Jump");
                isSwipingUp = false;
            }else if (isSwipingDown)
            {
                rb.velocity =  (new Vector2(rb.velocity.x,  -_playerStates.JumpSpeed * Time.fixedDeltaTime));
                Debug.Log("Land");
                isSwipingDown = false;
            }else if (isSwipingRight)
            {
                rb.velocity = (new Vector2(_playerStates.BoosterSpeed * Time.deltaTime, rb.velocity.y));
                Debug.Log("Booster");
                isSwipingRight = false;
            }else if (isSwipingLeft)
            {
                rb.velocity = (new Vector2( -_playerStates.BoosterSpeed * Time.deltaTime, rb.velocity.y));
                Debug.Log("Slow");

                isSwipingLeft = false;
            }


        }

        #endregion

        #region GetInput
        private void OnSwipeUp()
        {
            isSwipingUp = true;
        }
        private void OnSwipeDown()
        {
            isSwipingDown = true;
        }
        private void OnSwipeLeft()
        {
            isSwipingLeft = true;
        }
        private void OnSwipeRight()
        {
            isSwipingRight = true;
        }
        #endregion
    }
}