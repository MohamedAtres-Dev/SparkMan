using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "IsSwipeRightCondition", menuName = "State Machines/Conditions/Is Swipe Right Condition")]
public class IsSwipeRightConditionSO : StateConditionSO
{
	protected override Condition CreateCondition() => new IsSwipeRightCondition();
}

public class IsSwipeRightCondition : Condition
{
	protected new IsSwipeRightConditionSO OriginSO => (IsSwipeRightConditionSO)base.OriginSO;

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
