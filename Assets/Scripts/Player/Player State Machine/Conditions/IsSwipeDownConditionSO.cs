using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "IsSwipeDownCondition", menuName = "State Machines/Conditions/Is Swipe Down Condition")]
public class IsSwipeDownConditionSO : StateConditionSO
{
	protected override Condition CreateCondition() => new IsSwipeDownCondition();
}

public class IsSwipeDownCondition : Condition
{
	protected new IsSwipeDownConditionSO OriginSO => (IsSwipeDownConditionSO)base.OriginSO;

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
