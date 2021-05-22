using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "LandingAction", menuName = "State Machines/Actions/Landing Action")]
public class LandingActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new LandingAction();
}

public class LandingAction : StateAction
{
	protected new LandingActionSO OriginSO => (LandingActionSO)base.OriginSO;

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
