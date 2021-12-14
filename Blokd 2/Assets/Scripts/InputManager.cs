using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : Singleton<InputManager>
{

    #region Events
    public delegate void StartTouch(Vector2 position, float time);
    public event StartTouch OnStartTouch;
    public delegate void EndTouch(Vector2 position, float time);
    public event EndTouch OnEndTouch;
    #endregion

    private PlayerControls playerControls;
    private Camera mainCamera;

    private void Awake () {

        playerControls = new PlayerControls();
        mainCamera = Camera.main;
    }

    private void Enable() {

        playerControls.Enable();
    }

    private void OnDisable() {

        playerControls.Disable();
    }

    void Start()
    {
        playerControls.Touch.PrimaryContact.started += ctx => StartTouchPrimary(ctx);
        playerControls.Touch.PrimaryContact.canceled += ctx => EndTouchPrimary(ctx);

                Debug.Log("Start Input Manager");

    }
    
    private void StartTouchPrimary(InputAction.CallbackContext context) {
                Debug.Log("STP Input Manager 1");

        if (OnStartTouch != null) OnStartTouch(Utilities.ScreenToWorld(mainCamera, playerControls.Touch.PrimaryPosition.ReadValue<Vector2>()), (float)context.startTime);

                Debug.Log("STP Input Manager 2");

    }

    private void EndTouchPrimary(InputAction.CallbackContext context) {

        if (OnEndTouch != null) OnEndTouch(Utilities.ScreenToWorld(mainCamera, playerControls.Touch.PrimaryPosition.ReadValue<Vector2>()), (float)context.time);

                Debug.Log("ETP Input Manager");

    }

    public Vector2 PrimaryPosition() {

        return Utilities.ScreenToWorld(mainCamera, playerControls.Touch.PrimaryPosition.ReadValue<Vector2>());

                Debug.Log("PP Input Manager");

    }

}
