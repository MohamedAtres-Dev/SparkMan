using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputHandler", menuName = "Input/Player Input")]
public class InputHandler : ScriptableObject, MainControl.ITouchActions
{
    #region Events
    public event UnityAction<Vector2, float> onStartTouch = delegate { };
    public event UnityAction<Vector2, float> onEndTouch = delegate { };
    public event UnityAction jumpEvent = delegate { };

    private MainControl mainControl;
    #endregion

    #region Monobehaviour
    private void OnEnable()
    {
        if (mainControl == null)
        {
            mainControl = new MainControl();
            mainControl.Touch.SetCallbacks(this);
        }
        mainControl.Touch.Enable();
    }

    private void OnDisable()
    {
        mainControl.Touch.Disable();
    }

    #endregion

    #region Handle Input
    public void OnPrimaryContact(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            onStartTouch.Invoke(mainControl.Touch.PrimaryPosition.ReadValue<Vector2>(),
                (float)context.startTime);
        }

        if (context.canceled)
        {
            onEndTouch.Invoke(mainControl.Touch.PrimaryPosition.ReadValue<Vector2>(), 
                (float)context.time);
        }
    }

    public void OnPrimaryPosition(InputAction.CallbackContext context)
    {

    }

    public Vector2 PrimaryPosition()
    {
        return mainControl.Touch.PrimaryPosition.ReadValue<Vector2>();
    }
    #endregion
}
