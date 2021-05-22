using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "IsSwipeUpCondition", menuName = "State Machines/Conditions/Is Swipe Up Condition")]
public class IsSwipeUpConditionSO : StateConditionSO
{
	protected override Condition CreateCondition() => new IsSwipeUpCondition();
}

public class IsSwipeUpCondition : Condition
{
	protected new IsSwipeUpConditionSO OriginSO => (IsSwipeUpConditionSO)base.OriginSO;

	public override void Awake(StateMachine stateMachine)
	{
	}
	
	protected override bool Statement()
	{
		return true;
	}
	
	public override void OnStateEnter(StateMachine stateMachine)
	{
	}
	
	public override void OnStateExit(StateMachine stateMachine)
	{
	}
}
