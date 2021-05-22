using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "GravityAction", menuName = "State Machines/Actions/Gravity Action")]
public class GravityActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new GravityAction();
}

public class GravityAction : StateAction
{
	protected new GravityActionSO OriginSO => (GravityActionSO)base.OriginSO;

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
