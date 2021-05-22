using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "IsSwipeLeftCondition", menuName = "State Machines/Conditions/Is Swipe Left Condition")]
public class IsSwipeLeftConditionSO : StateConditionSO
{
	protected override Condition CreateCondition() => new IsSwipeLeftCondition();
}

public class IsSwipeLeftCondition : Condition
{
	protected new IsSwipeLeftConditionSO OriginSO => (IsSwipeLeftConditionSO)base.OriginSO;

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
