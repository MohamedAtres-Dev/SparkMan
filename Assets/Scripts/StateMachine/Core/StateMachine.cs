using System;
using System.Collections.Generic;
using UnityEngine;
using SparkBallGame;

namespace Mohamed.StateMachine
{
	public class StateMachine : MonoBehaviour
	{

		
		[Tooltip("Set the initial state of this StateMachine")]
		[SerializeField] private ScriptableObjects.TransitionTableSO _transitionTableSO = default;

#if UNITY_EDITOR
		[Space]
		[SerializeField]
		internal Debugging.StateMachineDebugger _debugger = default;
#endif

		private readonly Dictionary<Type, Component> _cachedComponents = new Dictionary<Type, Component>();
		internal State _currentState;

		[NonSerialized] public PlayerMovement _playerMovement = default;
		[NonSerialized] public Transform cameraTransform;

		private void Awake()
		{
			_currentState = _transitionTableSO.GetInitialState(this);
			_playerMovement = GetComponent<PlayerMovement>();
			cameraTransform = Camera.main.transform;
#if UNITY_EDITOR
			_debugger.Awake(this);
#endif
		}

		private void Start()
		{
			_currentState.OnStateEnter(this);
		}

		public new bool TryGetComponent<T>(out T component) where T : Component
		{
			var type = typeof(T);
			if (!_cachedComponents.TryGetValue(type, out var value))
			{
				if (base.TryGetComponent<T>(out component))
					_cachedComponents.Add(type, component);

				return component != null;
			}

			component = (T)value;
			return true;
		}

		public T GetOrAddComponent<T>() where T : Component
		{
			if (!TryGetComponent<T>(out var component))
			{
				component = gameObject.AddComponent<T>();
				_cachedComponents.Add(typeof(T), component);
			}

			return component;
		}

		public new T GetComponent<T>() where T : Component
		{
			return TryGetComponent(out T component)
				? component : throw new InvalidOperationException($"{typeof(T).Name} not found in {name}.");
		}

		private void Update()
		{
			if (_currentState.TryGetTransition(out var transitionState))
				Transition(transitionState);

			_currentState.OnUpdate();
		}

  //      private void FixedUpdate()
  //      {
		//	_currentState.OnFixedUpdate();
		//}

        private void Transition(State transitionState)
		{
			_currentState.OnStateExit(this);
			_currentState = transitionState;
			_currentState.OnStateEnter(this);
		}
	}
}
