using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{
    public class PlayerMovement : MonoBehaviour
    {
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

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion

        #region GetInput
        private void OnSwipeUp()
        {
            Debug.Log("Swipe Up Player Movement");
        }
        private void OnSwipeDown()
        {
            Debug.Log("Swipe Down Player Movement");
        }
        private void OnSwipeLeft()
        {
            Debug.Log("Swipe Left Player Movement");
        }
        private void OnSwipeRight()
        {
            Debug.Log("Swipe Right Player Movement");
        }
        #endregion
    }
}