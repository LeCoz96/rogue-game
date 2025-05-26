using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public PlayerInput.OnFootActions _onFoot;
    
    private PlayerInput _playerInput;

    private PlayerMovement _movement;
    //private PlayerLook _look;

    void Awake()
    {
        _playerInput = new PlayerInput();
        _onFoot = _playerInput.OnFoot;

        _movement = GetComponent<PlayerMovement>();
        _onFoot.Jump.performed += ctx => _movement.Jump();

        //_look = GetComponent<PlayerLook>();
    }

    void FixedUpdate()
    {
        _movement.ProcessMove(_onFoot.Movement.ReadValue<Vector2>());
    }

    //void LateUpdate()
    //{
    //    _look.ProcessLook(_onFoot.Look.ReadValue<Vector2>());
    //}

    private void OnEnable()
    {
        _onFoot.Enable();
    }

    private void OnDisable()
    {
        _onFoot.Disable();
    }
}
