using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{

    //Input
    private InputAction _moveInput;
    public Vector2 _moveAction;

    //Movement
    private Rigidbody _rigiBody;
    [SerializeField] private int _speed = 5;

    void Awake()
    {
        _moveInput = InputSystem.actions["Move"];

        _rigiBody = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveAction = _moveInput.ReadValue<Vector2>();
    }

    void Movement()
    {
        _rigiBody.linearVelocity = _moveAction * _speed;
    }

    
}
