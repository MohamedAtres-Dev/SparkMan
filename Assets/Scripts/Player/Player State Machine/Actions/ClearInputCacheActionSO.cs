using UnityEngine;
using Mohamed.StateMachine;
using Mohamed.StateMachine.ScriptableObjects;

[CreateAssetMenu(fileName = "ClearInputCacheAction", menuName = "State Machines/Actions/Clear Input Cache Action")]
public class ClearInputCacheActionSO : StateActionSO
{
	protected override StateAction CreateAction() => new ClearInputCacheAction();
}

public class ClearInputCacheAction : StateAction
{
	protected new ClearInputCacheActionSO OriginSO => (ClearInputCacheActionSO)base.OriginSO;

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
