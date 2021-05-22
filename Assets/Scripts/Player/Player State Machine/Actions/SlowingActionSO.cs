using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "SlowingAction", menuName = "State Machines/Actions/Slowing Action")]
public class SlowingActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new SlowingAction();
}

public class SlowingAction : StateAction
{
	protected new SlowingActionSO OriginSO => (SlowingActionSO)base.OriginSO;

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
