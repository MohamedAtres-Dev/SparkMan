using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


namespace SparkBallGame
{
    /// <summary>
    /// From this script I will get the final events of swipe
    /// </summary>
    public class PlayerInputManager : MonoBehaviour
    {
        #region Events
        public static UnityAction onSwipeUp = delegate { };
        public static UnityAction onSwipeDown = delegate { };
        public static UnityAction onSwipeLeft = delegate { };
        public static UnityAction onSwipeRight = delegate { };
        #endregion
        #region Fields
        [SerializeField] private InputHandler _inputHandler;
        [SerializeField] private float minDistance = 0.2f;
        [SerializeField] private float maxTime = 0.6f;
        [SerializeField, Range(0, 1.0f)]
        private float directionThreshold = 0.9f;
        [SerializeField] private GameObject trail;
        private Coroutine trialCoroutine;
        private Camera cam;

        //Detect swipe input
        private Vector2 _startPosition;
        private Vector2 _endPosition;

        private float _startTime;
        private float _endTime;
        #endregion

        #region Monobehaviour
        private void OnEnable()
        {
            _inputHandler.onStartTouch += _inputHandler_onStartTouch;
            _inputHandler.onEndTouch += _inputHandler_onEndTouch;
        }

        private void OnDisable()
        {
            _inputHandler.onStartTouch -= _inputHandler_onStartTouch;
            _inputHandler.onEndTouch -= _inputHandler_onEndTouch;
        }

        private void Start()
        {
            cam = Camera.main;
        }

        #endregion

        #region Handle Input

        private void _inputHandler_onStartTouch(Vector2 startPos, float startTime)
        {
            _startPosition = MathUtils.ScreenToWorld(cam, startPos);
            _startTime = startTime;

            //ToDO: remove this and add to the player sprite
            trail.SetActive(true);
            trail.transform.position = _startPosition;
            trialCoroutine = StartCoroutine(ActiveTrial());
        }

        //ToDO: remove this and add to the player sprite
        IEnumerator ActiveTrial()
        {
            while (true)
            {
                trail.transform.position = MathUtils.ScreenToWorld(cam, _inputHandler.PrimaryPosition());
                yield return null;
            }
        }

        private void _inputHandler_onEndTouch(Vector2 endPos, float endTime)
        {
            //ToDO: remove this and add to the player sprite
            trail.SetActive(false);
            StopCoroutine(trialCoroutine);


            _endPosition = MathUtils.ScreenToWorld(cam, endPos);
            _endTime = endTime;

            DetectSwipe();
        }

        private void DetectSwipe()
        {
            if (Vector3.Distance(_endPosition, _startPosition) >= minDistance
                && (_endTime - _startTime) < maxTime)
            {
                Debug.DrawLine(_startPosition, _endPosition, Color.red, 1f);
                Vector3 direction = _endPosition - _startPosition;
                Vector2 direction2D = new Vector2(direction.x, direction.y).normalized;
                SwipeDirection(direction2D);
            }
        }

        private void SwipeDirection(Vector2 direction)
        {
            if (Vector2.Dot(Vector2.up, direction) > directionThreshold)
            {
                Debug.Log("Swipe Up");
                onSwipeUp.Invoke();
            }
            else if (Vector2.Dot(Vector2.down, direction) > directionThreshold)
            {
                Debug.Log("Swipe Down");

                onSwipeDown.Invoke();
            }
            else if (Vector2.Dot(Vector2.left, direction) > directionThreshold)
            {
                Debug.Log("Swipe Left");
                onSwipeLeft.Invoke();
            }
            else if (Vector2.Dot(Vector2.right, direction) > directionThreshold)
            {
                Debug.Log("Swipe Right");
                onSwipeRight.Invoke();

            }
        }


        #endregion
    }
}