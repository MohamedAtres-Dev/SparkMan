using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "JumpingAction", menuName = "State Machines/Actions/Jumping Action")]
public class JumpingActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new JumpingAction();
}

public class JumpingAction : StateAction
{
	protected new JumpingActionSO OriginSO => (JumpingActionSO)base.OriginSO;

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
