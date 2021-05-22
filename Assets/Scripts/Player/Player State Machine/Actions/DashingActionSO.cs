using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "DashingAction", menuName = "State Machines/Actions/Dashing Action")]
public class DashingActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new DashingAction();
}

public class DashingAction : StateAction
{
	protected new DashingActionSO OriginSO => (DashingActionSO)base.OriginSO;

	public override void Awake(StateMachine stateMachine)
	{
	}
	
	public override void OnUpdate()
	{
	}
	
	public override void OnStateEnter(StateMachine stateMachine)
	{
	}
	
	public override void OnStateExit(StateMachine stateMachine)
	{
	}
}
